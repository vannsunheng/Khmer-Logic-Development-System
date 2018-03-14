using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public class Database
{
    private static string m_ConnectionString;
    private SqlConnection m_SqlConnection;
    private static string m_Server;
    private static string m_User;
    private static string m_Password;
    private static string m_Database;
    public string Server
    {
        get { return m_Server; }
        set { m_Server = value; }
    }
    public static void setConnectionString(string server, string database, string user = "", string password = "")
    {
        m_Server = server;
        m_Database = database;
        m_User = user;
        m_Password = password;
        string strConnectionString = "Data Source={0};Initial Catalog={1};User ID={2};Password={3};";
        string strConnectionString2 = "Data Source={0};Initial Catalog={1};Integrated Security=SSPI;";
        if (string.IsNullOrEmpty(user) & string.IsNullOrEmpty(password))
        {
            m_ConnectionString = string.Format(strConnectionString2, server, database);
        }
        else
        {
            m_ConnectionString = string.Format(strConnectionString, server, database, user, password);
        }


    }
    public SqlConnection Connection
    {
        get { return m_SqlConnection; }
        set { m_SqlConnection = value; }
    }
    public void CreateObjectSqlconnection()
    {
        try
        {
            m_SqlConnection = new SqlConnection(m_ConnectionString);
            m_SqlConnection.Open();
            if (this.m_SqlConnection.State == ConnectionState.Open)
            {
                m_SqlConnection.Close();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void CloseSqlConnection()
    {
        if (this.m_SqlConnection.State == ConnectionState.Open)
        {
            this.m_SqlConnection.Close();
        }
    }
    public void OpenSqlConnection()
    {
        if (this.m_SqlConnection.State == ConnectionState.Closed)
        {
            this.m_SqlConnection.Open();
        }
    }
    public string ConnectionString
    {
        get { return m_ConnectionString; }
        set { m_ConnectionString = value; }
    }
    public bool SqlConnection()
    {
        try
        {
            OpenSqlConnection();
            CloseSqlConnection();
            return true;
        }
        catch (Exception ex)
        {
            return false;
            throw ex;
        }
    }
    public DataTable GetTable(string Sql)
    {
        try
        {
            DataTable Table = new DataTable();
            DataSet Ds = new DataSet();
            this.OpenSqlConnection();
            System.Data.SqlClient.SqlDataAdapter ad = new System.Data.SqlClient.SqlDataAdapter(Sql, m_SqlConnection);
            ad.SelectCommand.CommandTimeout = 0;
            ad.Fill(Ds);
            Table = Ds.Tables[0];
            return Table;
        }
        catch (Exception ex)
        {
            //  vMessageBox.Show("មិនអាចធ្វើការតភ្ជាប់ទៅកាន់មូលដ្ឋានទិន្នន័យបានទេ\n សូមធ្វើការពិនិត្យឡើងវិញ ។\n", "Database Error", vMessageBox.Type.Warning)
            return null;
            throw ex;
        }
    }
    public bool IsIDExisted(string Tbl, int ID)
    {
        bool Bool = false;
        string Query = null;
        DataTable Dt = new DataTable();
        Query = "select top 1 id from " + Tbl + " where id=" + ID;
        Dt = GetTable(Query);
        if (Dt.Rows.Count > 0)
        {
            Bool = true;
        }
        return Bool;
    }
    public string getValue(string sql)
    {
        try
        {
            DataTable dt = new DataTable();
            dt = this.GetTable(sql);
            return dt.Rows[0][0].ToString();
        }
        catch (Exception ex)
        {
            return "";
            throw ex;
        }

    }
    internal void ExecuteNoneQuery(string Sql)
    {
        try
        {
            this.OpenSqlConnection();
            System.Data.SqlClient.SqlCommand sqlCmd = default(System.Data.SqlClient.SqlCommand);

            sqlCmd = new SqlCommand(Sql, m_SqlConnection);
            sqlCmd.CommandTimeout = int.MaxValue;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    internal void ExecuteBatchNonQuery(string sql)
    {


        string sqlBatch = string.Empty;
        SqlCommand cmd = new SqlCommand(string.Empty, m_SqlConnection);
        this.OpenSqlConnection();
        sql += "" + "GO";
        // make sure last batch is executed.
        try
        {
            foreach (string line in sql.Split(new string[2] {
                "\n","\r"
                }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (line.ToUpperInvariant().Trim() == "GO")
                {
                    cmd.CommandText = sqlBatch;
                    if (sqlBatch == string.Empty || string.IsNullOrEmpty(sqlBatch))
                    {
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                    }

                    sqlBatch = string.Empty;
                }
                else
                {
                    sqlBatch += line + Convert.ToString("\n");
                }
            }

        }
        catch (Exception Exception)
        {
            throw Exception;
        }
        finally
        {
        }
    }


    internal void ExecuteSqlQuery(string sql)
    {
        int i = 0;
        // Create segments of the string called "lines" each separated by "GO" 
        System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("GO", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        string[] lines = regex.Split(sql);
        this.OpenSqlConnection();
        System.Data.SqlClient.SqlCommand sqlCmd;

        sqlCmd = new SqlCommand();
        sqlCmd.CommandTimeout = int.MaxValue;
        sqlCmd.CommandType = CommandType.Text;
        sqlCmd.Connection = m_SqlConnection;

        // Execute as a transaction, roll back if it fails
        SqlTransaction transaction = m_SqlConnection.BeginTransaction();
        sqlCmd.Transaction = transaction;

        for (i = 0; i <= lines.Length - 1; i++)
        {
            if (lines[i].Length > 0)
            {
                try
                {
                    sqlCmd.CommandText = lines[i];
                    sqlCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Connection.Close();
                    return;
                    throw ex;
                }
            }
        }

        transaction.Commit();
        Connection.Close();
    }
    internal int ExecuteScalar(string Sql)
    {
        try
        {
            this.OpenSqlConnection();
            System.Data.SqlClient.SqlCommand sqlCmd = default(System.Data.SqlClient.SqlCommand);
            sqlCmd = new SqlCommand(Sql + " " + "SELECT @@IDENTITY SET NOCOUNT ON;", m_SqlConnection);
            sqlCmd.CommandType = CommandType.Text;
            return (int)sqlCmd.ExecuteScalar();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }
    internal void LoadDataToComboBox(ref ComboBox cbo, string sql)
    {
        this.OpenSqlConnection();
        System.Data.SqlClient.SqlDataAdapter ad = new System.Data.SqlClient.SqlDataAdapter(sql, m_SqlConnection);
        DataSet ds = new DataSet();
        DataTable table = new DataTable();
        ad.Fill(ds);
        table = ds.Tables[0];
        cbo.ValueMember = table.Columns[0].ToString();
        cbo.DisplayMember = table.Columns[1].ToString();
        cbo.DataSource = table;
        ad.Dispose();
    }
    internal void LoadDataToListView(ref ListView lsv, string sql)
    {
        this.OpenSqlConnection();
        lsv.Items.Clear();
        System.Data.SqlClient.SqlDataAdapter ad = new System.Data.SqlClient.SqlDataAdapter(sql, m_SqlConnection);
        DataSet ds = new DataSet();
        DataTable table = new DataTable();
        ad.Fill(ds);
        table = ds.Tables[0];
        for (int i = 0; i <= table.Rows.Count - 1; i++)
        {
            ListViewItem lsvi = new ListViewItem();
            lsvi.Text = table.Rows[i][0].ToString();
            for (int k = 1; k <= table.Columns.Count - 1; k++)
            {
                lsvi.SubItems.Add(table.Rows[i][k].ToString());
            }
            lsv.Items.Add(lsvi);
        }
        ad.Dispose();
    }
    public void LoadDatatoCombo(ref ToolStripComboBox cbo, string sql)
    {
        this.OpenSqlConnection();
        System.Data.SqlClient.SqlDataAdapter ad = new System.Data.SqlClient.SqlDataAdapter(sql, Connection);
        DataSet ds = new DataSet();
        DataTable table = new DataTable();
        ad.Fill(ds, sql);
        table = ds.Tables[0];
        cbo.ComboBox.ValueMember = table.Columns[0].ToString();
        cbo.ComboBox.DisplayMember = table.Columns[1].ToString();
        cbo.ComboBox.DataSource = table;
        ad.Dispose();
        this.CloseSqlConnection();
    }
    internal void LoadDataToLookUpEdit(DevExpress.XtraEditors.LookUpEdit lue, string sql)
    {
        if (((sql == null) || (sql == "")))
        {
            return;
        }
        this.OpenSqlConnection();
        System.Data.SqlClient.SqlDataAdapter ad = new System.Data.SqlClient.SqlDataAdapter(sql, m_SqlConnection);
        DataSet ds = new DataSet();
        DataTable table = new DataTable();
        ad.Fill(ds);
        table = ds.Tables[0];
        lue.Properties.DataSource = table;
        lue.Properties.ValueMember = table.Columns[0].ToString();
        lue.Properties.DisplayMember = table.Columns[1].ToString();
        ad.Dispose();
    }
    internal bool CheckValue(string wssql)
    {
        bool functionReturnValue = false;
        functionReturnValue = false;
        this.OpenSqlConnection();
        SqlCommand wsSqlCommand = new SqlCommand();
        wsSqlCommand.Connection = m_SqlConnection;
        SqlDataReader wsDatareader = null;
        try
        {
            wsSqlCommand.CommandText = wssql;
            wsDatareader = wsSqlCommand.ExecuteReader();
            if (wsDatareader.Read() == true)
            {
                functionReturnValue = true;
            }
            wsSqlCommand.Dispose();

        }
        catch (Exception ex)
        {
            throw ex;
        }
        wsDatareader.Close();
        return functionReturnValue;
    }
}
