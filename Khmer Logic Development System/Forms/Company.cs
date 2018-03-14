using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public partial class Company : Form, IPage
{
    private Main main;
    public Company()
    {
        InitializeComponent();
    }
    public void AddNew()
    {

    }
    public void Clear()
    {

    }
    public void Edit()
    {

    }
    public void Reload()
    {

    }
    public void Remove()
    {

    }
    public void Search()
    {
    }
    public void Search(string testValue, string column = "")
    {

    }
    public void View()
    {

    }

    private void Company_Load(object sender, EventArgs e)
    {
        main = Main.GetInstance();
        panel1.BackColor = Setting.mainColor;
        lblName.ForeColor = Setting.subColor;
        try
        {
            DataTable dt = new DataTable();
            string sql = @"SELECT TOP 1 Company,EnglishName,ISNULL(Slogan,'') Slogan,ISNULL(Website,'') website
,ISNULL(Email,'') Email,ISNULL(Address,'') [Address],Logo
,ISNULL(MainColor,'') MainColor,ISNULL(SubColor,'') SubColor
,ISNULL(VATNumber,'') VATNumber,ISNULL(Province,'') Province
,ISNULL(Phone,'000') Phone
 FROM dbo.Company";
            dt = main.GetTable(@"SELECT TOP 1 *FROM dbo.Company");
            if (dt.Rows.Count == 0)
            {
                main.ExecuteNoneQuery(string.Format(@"INSERT INTO dbo.Company(Company,EnglishName)VALUES(N'{0}',N'{1}')", Setting.CompanyName, Setting.CompanyEngName));
                dt = main.GetTable(sql);
            }
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["Company"].ToString();
                txtNameEng.Text = dt.Rows[0]["EnglishName"].ToString();
                txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                txtVAT.Text = dt.Rows[0]["VATNUmber"].ToString();
                txtSlogon.Text = dt.Rows[0]["Slogan"].ToString();
                txtWebsite.Text = dt.Rows[0]["website"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                byte[] array = Encoding.ASCII.GetBytes(dt.Rows[0]["Logo"].ToString());
                picLogo.Image = Converters.ConvertByteToImage(array) == null ? null : Converters.ConvertByteToImage(array);
            }
        }
        catch (Exception ex)
        {
            //throw ex;
        }
    }

    private void pnMainColor_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        try
        {
            ColorDialog cdl = new ColorDialog();
            cdl.Color = pnMainColor.BackColor;
            if (cdl.ShowDialog() == DialogResult.OK)
            {
                pnMainColor.BackColor = cdl.Color;
                Setting.mainColor = cdl.Color;
            }

        }
        catch (Exception ex) { }
    }

    private void pnSubcolor_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        try
        {
            ColorDialog cdl = new ColorDialog();
            cdl.Color = pnSubcolor.BackColor;
            if (cdl.ShowDialog() == DialogResult.OK)
            {
                pnSubcolor.BackColor = cdl.Color;
                Setting.mainColor = cdl.Color;
            }

        }
        catch (Exception ex) { }
    }
}

