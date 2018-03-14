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
public partial class LoginForm : Form, IPage
{
    private Main main;
    public bool isCorrect = false;
    public LoginForm()
    {
        InitializeComponent();
    }
    public void AddNew() { }
    public void Clear() { }
    public void Edit() { }
    public void Reload() { }
    public void Remove() { }
    public void Search() { }
    public void Search(string testValue, string column = "") { }
    public void View() { }
    private void LoginForm_Load(object sender, EventArgs e)
    {
        try
        {
            txtUser.Text = Registry.GetRegKey("LastLogin");
            txtPassword.Focus();
            Main.setConnectionString(Registry.GetRegKey("Server"), Registry.GetRegKey("Database"), Registry.GetRegKey("UserName"), Registry.GetRegKey("Password"));
            main = Main.GetInstance();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            Connection frm = new Connection();
            frm.ShowDialog();
            frm = null;
            Application.Exit();
        }
        txtUser.KeyDown += new KeyEventHandler(LoginForm_KeyDown);
        txtPassword.KeyDown += new KeyEventHandler(LoginForm_KeyDown);
        btnSave.KeyDown += new KeyEventHandler(LoginForm_KeyDown);
        btnClose.KeyDown += new KeyEventHandler(LoginForm_KeyDown);
        txtPassword.Focus();

    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtUser.Text))
            txtUser.Focus();
        else if (string.IsNullOrEmpty(txtPassword.Text))
            txtPassword.Focus();
        else
        {
            DataTable dt = new DataTable();
            string sql = "select U.ID ,U.UserName,U.BranchID,B.Name,U.Role,ISNULL(U.IsHeadview,0) IsHeadView,B.Code,ISNULL(u.allowConsolidate,0) AllowConsolidate,ISNULL(u.isAdmin,0) isAdmin,U.MacAddress from [User] U inner join Branch B ON B.ID=U.BranchID WHERE U.USERNAME={0} AND U.Password={1}";
            sql = string.Format(sql, General.sqlStringNull(txtUser), General.sqlStringNull(txtPassword));
            dt = main.GetTable(sql);
            if (dt == null || dt.Rows.Count < 0)
            {
                MessageBox.Show("Invalide Username and Password! ");
                return;
            }
            else
            {
                main.User.ID = (int)dt.Rows[0]["ID"];
                main.User.Name = dt.Rows[0]["UserName"].ToString();
                main.User.BranchID = (int)dt.Rows[0]["BranchID"];
                main.User.BranchName = dt.Rows[0]["Name"].ToString();
                main.User.Role = int.Parse(dt.Rows[0]["Role"].ToString());
                main.User.IsHeadView = (bool)dt.Rows[0]["IsHeadView"];
                main.User.BranchCode = dt.Rows[0]["Code"].ToString();
                main.User.isAdmin = (bool)dt.Rows[0]["isAdmin"];
                main.User.AllowConsolidate = (bool)dt.Rows[0]["AllowConsolidate"];
                main.User.MacAddress = dt.Rows[0]["MacAddress"].ToString();
                isCorrect = true;
                Registry.SetRegKey("LastLogin", txtUser.Text);
                this.Close();
            }
            dt = null;
        }
    }
    private void LoginForm_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F12)
        {
            Connection frm = new Connection();
            frm.ShowDialog();
        }
    }

    private void LoginForm_Shown(object sender, EventArgs e)
    {
        txtPassword.Focus();
    }
}

