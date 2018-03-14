using System;
using System.IO;
using System.Data;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
public class ParamaterPrinter : IDisposable
{
    private int m_currentPageIndex;
    private IList<Stream> m_streams;
    public int CUAccountID;
    private Main main;
    private DataTable LoadSalesData()
    {
        DataSet dataSet = new DataSet();
        dataSet.ReadXml("..\\..\\data.xml");
        return dataSet.Tables[0];
    }
    private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
    {
        Stream stream = new FileStream(("C:\\" + (name + ("." + fileNameExtension))), FileMode.Create);
        m_streams.Add(stream);
        return stream;
    }
    private void Export(LocalReport report)
    {
        string deviceInfo = ("<DeviceInfo>" + ("<OutputFormat>EMF</OutputFormat>" +
            ("<PageWidth>8.5in</PageWidth>" +
            ("<PageHeight>11in</PageHeight>" +
            ("<MarginTop>0.25in</MarginTop>" +
            ("<MarginLeft>0.25in</MarginLeft>" +
            ("<MarginRight>0.25in</MarginRight>" +
            ("<MarginBottom>0.25in</MarginBottom>" +
            "</DeviceInfo>"))))))));
        Warning[] warnings;
        m_streams = new List<Stream>();
        report.Render("Image", deviceInfo, CreateStream, out warnings);
        foreach (Stream stream in m_streams)
        {
            stream.Position = 0;
        }

    }

    //  Handler for PrintPageEvents
    private void PrintPage(object sender, PrintPageEventArgs ev)
    {
        Metafile pageImage = new Metafile(m_streams[m_currentPageIndex]);
        Rectangle adjustedRect = new Rectangle((ev.PageBounds.Left - int.Parse(ev.PageSettings.HardMarginX.ToString())), (ev.PageBounds.Top - int.Parse(ev.PageSettings.HardMarginY.ToString())), ev.PageBounds.Width, ev.PageBounds.Height);
        ev.Graphics.FillRectangle(Brushes.White, adjustedRect);
        ev.Graphics.DrawImage(pageImage, adjustedRect);
        m_currentPageIndex++;
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
    }

    private void Print()
    {
        if (((m_streams == null)
                    || (m_streams.Count == 0)))
        {
            throw new Exception("Error: no stream to print.");
        }

        PrintDocument printDoc = new PrintDocument();
        if (!printDoc.PrinterSettings.IsValid)
        {
            throw new Exception("Error: cannot find the default printer.");
        }
        else
        {
            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
            m_currentPageIndex = 0;
            printDoc.Print();
        }

    }

    //  Create a local report for Report.rdlc, load the data,
    //  export the report to an .emf file, and print it.
    private void Run()
    {
        LocalReport report = new LocalReport();
        report.ReportPath = "..\\..\\Report.rdlc";
        report.DataSources.Add(new ReportDataSource("Sales", this.LoadSalesData()));
        this.Export(report);
        this.Print();
    }

    public void Dispose()
    {
        if (m_streams != null)
        {

            foreach (Stream stream in m_streams)
            {
                stream.Close();
            }

            m_streams = null;
        }

    }

    public static void PrintReport(int AccountID)
    {
        using (ParamaterPrinter demo = new ParamaterPrinter())
        {
            demo.main = Main.GetInstance();
            demo.CUAccountID = AccountID;
        }
    }
}