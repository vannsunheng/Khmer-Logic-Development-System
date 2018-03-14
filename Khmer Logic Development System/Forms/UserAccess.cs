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
public partial class UserAccess : Form, IPage
{
    public UserAccess()
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

    }
    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}

