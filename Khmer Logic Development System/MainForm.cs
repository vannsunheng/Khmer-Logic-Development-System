using Khmer_Logic_Development_System;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private Main main;
    private bool IsLogout;

    public MainForm()
    {
        InitializeComponent();
    }
    private INavigator CurrentNavigator()
    {
        return this.currentPage as INavigator;
    }
    private IPage CurrentPages()
    {
        return this.currentPage as IPage;
    }
    private Control currentPage = null;
    private Dictionary<string, Control> pages = new Dictionary<string, Control>();
    public void showPage(Type types)
    {
        string name = types.Name;
        if (!this.pages.ContainsKey(name))
        {
            this.pages[name] = (Control)Activator.CreateInstance(types);
            this.pages[name].Tag = (object)name;
            this.pages[name].Size = this.panChild.Size;
            if (this.pages[name] is Form)
            {
                Form page = (Form)this.pages[name];
                page.TopLevel = false;
                page.FormBorderStyle = FormBorderStyle.None;
            }
            this.panChild.Controls.Add(this.pages[name]);
            this.pages[name].Dock = DockStyle.Fill;
        }
        if (this.currentPage != this.pages[name])
        {
            this.pages[name].Show();
            if (((object)this.currentPage) != null)
                this.currentPage.Hide();
            this.currentPage = this.pages[name];
        }
        this.pages[name].Focus();
        try
        {
            this.Text = Setting.CompanyEngName + " | " + this.pages[name].Text;
        }
        catch(Exception ex) { MessageBox.Show(ex.Message); }

       
    }

    public void showPage(string Name)
    {
        string key = Name;
        Type type = Type.GetType(Name);
        if (!this.pages.ContainsKey(key))
        {
            this.pages[key] = (Control)Activator.CreateInstance(type);
            this.pages[key].Tag = (object)key;
            this.pages[key].Size = this.panChild.Size;
            if (this.pages[key] is Form)
            {
                Form page = (Form)this.pages[key];
                page.TopLevel = false;
                page.FormBorderStyle = FormBorderStyle.None;
            }
            this.panChild.Controls.Add(this.pages[key]);
            this.pages[key].Dock = DockStyle.Fill;
        }
        if (this.currentPage != this.pages[key])
        {
            this.pages[key].Show();
            if (((object)this.currentPage) != null)
                this.currentPage.Hide();
            this.currentPage = this.pages[key];
        }
        this.pages[key].Focus();
        this.Text = Setting.CompanyEngName + " | " + this.pages[key].Text;
    }

    public void showPage(ReportViewer Report)
    {
        string key = Report.Tag.ToString();
        if (!this.pages.ContainsKey(key))
        {
            this.pages[key] = (Control)Report;
            this.pages[key].Size = this.panChild.Size;
            if (this.pages[key] is Form)
            {
                Form page = (Form)this.pages[key];
                page.TopLevel = false;
                page.FormBorderStyle = FormBorderStyle.None;
            }
            this.panChild.Controls.Add(this.pages[key]);
            this.pages[key].Dock = DockStyle.Fill;
        }
        if (this.currentPage != this.pages[key])
        {
            this.pages[key].Show();
            if (((object)this.currentPage) != null)
                this.currentPage.Hide();
            this.currentPage = this.pages[key];
        }
        this.pages[key].Focus();
        this.Text = Setting.CompanyEngName + " | " + this.pages[key].Text;
    }

    public void showPage(FormReport Report)
    {
        string key = Report.Tag.ToString();
        if (!this.pages.ContainsKey(key))
        {
            this.pages[key] = (Control)Report;
            this.pages[key].Size = this.panChild.Size;
            if (this.pages[key] is Form)
            {
                Form page = (Form)this.pages[key];
                page.TopLevel = false;
                page.FormBorderStyle = FormBorderStyle.None;
            }
            this.panChild.Controls.Add(this.pages[key]);
            this.pages[key].Dock = DockStyle.Fill;
        }
        if (this.currentPage != this.pages[key])
        {
            this.pages[key].Show();
            if (((object)this.currentPage) != null)
                this.currentPage.Hide();
            this.currentPage = this.pages[key];
        }
        this.pages[key].Focus();
        this.Text = Setting.CompanyEngName + " | " + this.pages[key].Text;
    }
    private void MainForm_Load(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Maximized;
        this.Hide();
        this.showPage(typeof(Dashboard));
        if (checkLicense() == false)
        {
            MessageBox.Show("You didn't have register this software yet !", "Warning Message");
            Application.Exit();
        }
        LoginForm frm = new LoginForm();
        frm.ShowDialog();
        if (frm.isCorrect == false)
        {
            Application.Exit();
        }
        main = Main.GetInstance();
        LoadBranch();
        if (IsLogout == true)
        {
            Application.Exit();
        }
        lblUser.Text = main.User.Name;
        lblServer.Text = Registry.GetRegKey("Server");
        lblversion.Text = Setting.Version;
        lblLicence.Text = Setting.License;

    }
    private void LoadBranch()
    {
        string sql = @"SELECT b.ID,b.Name FROM dbo.Branch b INNER JOIN UserBranchMap ubm ON 
b.ID=ubm.BranchID INNER JOIN [User] u ON u.ID=ubm.UserID
WHERE b.Active=1 AND u.MacAddress={0}";
        sql = string.Format(sql, General.sqlStringNull(main.User.MacAddress));
        DataTable dtbranch = new DataTable();
        dtbranch = main.GetTable(sql);
        if (dtbranch.Rows.Count == 0 || dtbranch == null)
        {
            MessageBox.Show("Sorry you can't access any branch !!", "Invalid Branch Access");
            IsLogout = true;
        }
        else
        {
            main.LoadDatatoCombo(ref cboBranch, sql);
        }
    }
    List<License> lstLicense = new List<License>();
    public bool checkLicense()
    {
        lstLicense.Add(new License("98:54:1B:29:8D:5C", "KHMERLOGIC", "SUNHENG"));
        lstLicense.Add(new License("18:DB:F2:41:80:C8", "KHMERLOGIC", "SUPER Admin"));
        lstLicense.Add(new License("68:07:15:4C:58:28", "KHMERLOGIC", "HENG"));
        foreach (string Mac in getMacAddress())
            foreach (License item in lstLicense)
            {
                if ((Mac == item.mac_add))
                {
                    Setting.License = item.company_name;
                    Setting.DisplayLicese = item.DisplayName;
                    return true;
                }

            }
        return false;
    }
    string[] getMacAddress()
    {
        List<string> str = new List<string>();
        NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
        foreach (NetworkInterface s in nics)
        {
            string st = "{0}:{1}:{2}:{3}:{4}:{5}";
            string st2 = s.GetPhysicalAddress().ToString();
            try
            {
                if ((st2 != ""))
                {
                    str.Add(string.Format(st, st2.Substring(0, 2), st2.Substring(2, 2), st2.Substring(4, 2), st2.Substring(6, 2), st2.Substring(8, 2), st2.Substring(10, 2)));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        if ((str.Count == 0))
        {
            str.Add("00:00:00:00:00:00");
        }

        return str.ToArray<string>();
    }

    private void Refresh_Click(object sender, EventArgs e)
    {
        INavigator navigator = this.CurrentNavigator();
        if ((navigator) != null)
        {
            IPage page = navigator.CurrentPage();
            if ((page) == null)
                return;
            page.Reload();
        }
        else
        {
            IPage currentPage = (IPage)this.currentPage;
            if ((currentPage) != null)
                currentPage.Reload();
        }
    }
    private void Previous_Click(object sender, EventArgs e)
    {
        try
        {
            int found = 0;
            string nextPage = "";
            foreach (string s in pages.Keys)
            {
                if ((s == this.currentPage.Tag.ToString()))
                {
                    found = 1;
                    break;
                }
                nextPage = s;
            }
            if ((nextPage != ""))
            {
                this.showPage(nextPage);
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    private void Next_Click(object sender, EventArgs e)
    {
        try
        {
            int found = 0;
            string nextPage = "";
            foreach (string s in pages.Keys)
            {
                if ((found == 1))
                {
                    nextPage = s;
                    break;
                }
                if ((s == this.currentPage.Tag.ToString()))
                {
                    found = 1;
                }

            }

            if ((nextPage != ""))
            {
                this.showPage(nextPage);
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private void Close_Click(object sender, EventArgs e)
    {
        try
        {
            if ((this.currentPage.Name != "Dashboard"))
            {
                INavigator curNav = this.CurrentNavigator();
                if (!(curNav == null))
                {
                    IPage curPage = curNav.CurrentPage();
                    if (!(curPage == null))
                    {
                        ((Form)(curPage)).Close();
                        string stTMp = this.currentPage.Tag.ToString();
                        Previous_Click(sender, e);
                        pages.Remove(stTMp);
                    }

                }
                else
                {
                    IPage curPage = this.CurrentPages();
                    if (!(curPage == null))
                    {
                        ((Form)(curPage)).Close();
                        string stTMp = this.currentPage.Tag.ToString();
                        Previous_Click(sender, e);
                        pages.Remove(stTMp);
                    }

                }

            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Connection frm = new Connection();
        frm.ShowDialog();
    }
    private void MainForm_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F12)
        {
            Connection frm = new Connection();
            frm.ShowDialog();
        }
    }

    private void helpToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.showPage(typeof(Company));
    }
}