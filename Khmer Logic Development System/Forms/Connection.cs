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
public partial class Connection : Form, IPage
{
    public Connection()
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
    private void Connection_Load(object sender, EventArgs e)
    {
        panel1.BackColor = Setting.mainColor;
        label1.Text = this.Text;
        txtServer.Text = Registry.GetRegKey("Server");
        txtUser.Text = Registry.GetRegKey("UserName");
        txtPassword.Text = Registry.GetRegKey("Password");
        txtDatabase.Text = Registry.GetRegKey("Database");
        txtServer.KeyDown += new KeyEventHandler(Connection_KeyDown);
        txtDatabase.KeyDown += new KeyEventHandler(Connection_KeyDown);
        txtPassword.KeyDown += new KeyEventHandler(Connection_KeyDown);
        txtUser.KeyDown += new KeyEventHandler(Connection_KeyDown);
        ch.KeyDown += new KeyEventHandler(Connection_KeyDown);
        btnClose.KeyDown += new KeyEventHandler(Connection_KeyDown);
        btnSave.KeyDown += new KeyEventHandler(Connection_KeyDown);
        btnTest.KeyDown += new KeyEventHandler(Connection_KeyDown);
        groupBox1.KeyDown += new KeyEventHandler(Connection_KeyDown);

    }

    private void ch_CheckedChanged(object sender, EventArgs e)
    {
        txtUser.Enabled = !ch.Checked;
        txtPassword.Enabled = !ch.Checked;
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection();
            string constring1 = "Data Source={0};Initial Catalog={1};User ID={2};Password={3};";
            string constring2 = "Data Source={0};Initial Catalog={1};Integrated Security=SSPI;";
            if (ch.Checked == false)
            {
                con.ConnectionString = string.Format(constring1, txtServer.Text.Trim(), txtDatabase.Text.Trim(), txtUser.Text.Trim(), txtPassword.Text.Trim());
            }
            else
                con.ConnectionString = string.Format(constring2, txtServer.Text.Trim(), txtDatabase.Text.Trim());
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                MessageBox.Show("Connection Succesfully!");
                con.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (ch.Checked == true)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
        }
        Registry.SetRegKey("Server", txtServer.Text);
        Registry.SetRegKey("UserName", txtUser.Text);
        Registry.SetRegKey("Password", txtPassword.Text);
        Registry.SetRegKey("Database", txtDatabase.Text);
        this.Close();
    }

    private void Connection_KeyDown(object sender, KeyEventArgs e)
    {
        if ((e.KeyCode == Keys.S) && (e.Modifiers == Keys.Control))
        {
            btnSave.PerformClick();
        }
        else if ((e.KeyCode == Keys.Escape))
        {
            btnClose.PerformClick();
        }
        else if ((e.KeyCode == Keys.F5))
        {
            btnTest.PerformClick();
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}

