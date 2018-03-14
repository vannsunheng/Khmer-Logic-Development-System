using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class User
{
    private int m_ID;
    private string m_Name;
    private string m_Password;
    private string m_Counter;
    private int m_ComputerID;
    private int m_Role;
    private Image m_Photo;
    private int m_BranchID;
    private string m_BranchName;
    private string m_branchCode;
    private bool m_accessanybranch;
    private int m_terminalID;
    private string m_terminalName;
    private bool m_isAdmin;
    public string MacAddress;
    public bool is_headview;
    public bool allow_consolidate;
    public string BranchCode
    {
        get { return m_branchCode; }
        set { m_branchCode = value; }
    }
    public bool isAdmin
    {
        get { return m_isAdmin; }
        set { m_isAdmin = value; }
    }
    public bool AllowConsolidate
    {
        get { return allow_consolidate; }
        set { allow_consolidate = value; }
    }
    public bool IsHeadView
    {
        get { return is_headview; }
        set { is_headview = value; }
    }
    public string TerminalName
    {
        get { return m_terminalName; }
        set { m_terminalName = value; }
    }
    public int TerminalID
    {
        get { return m_terminalID; }
        set { m_terminalID = value; }
    }
    public bool AccessAnyBrach
    {
        get { return m_accessanybranch; }
        set { m_accessanybranch = value; }
    }
    public string BranchName
    {
        get { return m_BranchName; }
        set { m_BranchName = value; }
    }
    public User() { }
    public User(int ID, string Name, string Password, string Counter, int ComputerID, int Role, Image Photo, int BranchID)
    {
        m_ID = ID;
        m_Name = Name;
        m_Password = Password;
        m_Counter = Counter;
        m_ComputerID = ComputerID;
        m_Role = Role;
        m_Photo = Photo;
        m_BranchID = BranchID;
    }
    internal int ID
    {
        get { return m_ID; }
        set { m_ID = value; }
    }
    internal string Name
    {
        get { return m_Name; }
        set { m_Name = value; }
    }
    internal string Password
    {
        get { return m_Password; }
        set { m_Password = value; }
    }
    internal string Counter
    {
        get { return m_Counter; }
        set { m_Counter = value; }
    }
    internal int ComputerID
    {
        get { return m_ComputerID; }
        set { m_ComputerID = value; }
    }
    internal int Role
    {
        get { return m_Role; }
        set { m_Role = value; }
    }
    internal Image Photo
    {
        get { return m_Photo; }
        set { m_Photo = value; }
    }
    internal int BranchID
    {
        get { return m_BranchID; }
        set { m_BranchID = value; }
    }

}


