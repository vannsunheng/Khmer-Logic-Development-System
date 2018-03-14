using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Main : Database
{

    public static Main Instance;
    private User m_User = new User();
    public DataTable HolidayData = new DataTable();

    private Main()
    {
        CreateObjectSqlconnection();
    }

    internal User User
    {
        get
        {
            return m_User;
        }
        set
        {
            m_User = value;
        }
    }

    public static Main GetInstance()
    {
        try
        {
            if ((Instance == null))
            {
                Instance = new Main();
            }
            return Instance;

        }
        catch (Exception ex)
        {
            return null;
            throw ex;
        }
    }

    public static Main GetInstance(string connectionString)
    {
        try
        {
            Instance = new Main();
            return Instance;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

    }

    public void ClearAllBox(GroupBox Gbx)
    {
        foreach (Control cr in Gbx.Controls)
        {
            switch (cr.Tag.ToString().Substring(0, 1))
            {
                case "T":
                    cr.Text = "";
                    break;
                case "A":
                    cr.Text = "Autonumber";
                    break;
                case "N":
                    cr.Text = "0";
                    break;
            }
        }

    }


    void ClearAllBox(Panel Gbx)
    {
        foreach (Control cr in Gbx.Controls)
        {
            switch (cr.Tag.ToString().Substring(0, 1))
            {
                case "T":
                    cr.Text = "";
                    break;
                case "A":
                    cr.Text = "Autonumber";
                    break;
                case "N":
                    cr.Text = "0";
                    break;
            }
        }

    }

    void ClearAllBox(SplitContainer Gbx)
    {
        foreach (Control cr in Gbx.Controls)
        {
            switch (cr.Tag.ToString().Substring(0, 1))
            {
                case "T":
                    cr.Text = "";
                    break;
                case "A":
                    cr.Text = "Autonumber";
                    break;
                case "N":
                    cr.Text = "0";
                    break;
            }
        }

    }

    void ClearAllPanel(Panel Panel)
    {
        foreach (Control cr in Panel.Controls)
        {
            switch (cr.Tag.ToString().Substring(0, 1))
            {
                case "T":
                    cr.Text = "";
                    break;
                case "A":
                    cr.Text = "Autonumber";
                    break;
                case "N":
                    cr.Text = "0";
                    break;
            }
        }

    }

    string IsAllPanelNull(Panel grd)
    {
        string null_ = "";
        foreach (Control cr in grd.Controls)
        {
            if (((cr.GetType() == typeof(TextBox) || ((cr.GetType() == typeof(ComboBox)) || (cr.GetType() == typeof(MaskedTextBox))))))
            {
                if (((cr.Text == "")
                            && (cr.Tag.ToString().Substring((cr.Tag.ToString().Length - 1)) != "C")))
                {
                    cr.Focus();
                    null_ = cr.Name;
                }

            }

        }

        return null_;
    }

    string IsAllPanelNull(GroupBox grd)
    {
        string null_ = "";
        foreach (Control cr in grd.Controls)
        {
            if (((cr.GetType() == typeof(TextBox))
                        || ((cr.GetType() == typeof(ComboBox))
                        || (cr.GetType() == typeof(MaskedTextBox)))))
            {
                if (((cr.Text == "")
                            && (cr.Tag.ToString().Substring((cr.Tag.ToString().Length - 1)) != "C")))
                {
                    cr.Focus();
                    null_ = cr.Name;
                }

            }

        }

        return null_;
    }

    public static void setGrdHeader(string HD, DataGridView GRD)
    {
        string[] H;
        H = HD.Split('|');
        int i;
        for (i = 0; (i <= H.GetUpperBound(0)); i++)
        {
            GRD.Columns[i].HeaderText = H[i];
        }

    }

    public static void setGrdWidth(string HD, DataGridView GRD)
    {
        string[] H;
        H = HD.Split('|');
        int i;
        for (i = 0; (i <= H.GetUpperBound(0)); i++)
        {
            GRD.Columns[i].Width = int.Parse(H[i]);
        }

    }
}