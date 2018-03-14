using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public static class General
{
    public static bool AddCommandTextBox(StatusStrip sta, int position = 1, int width = 150)
    {
        ToolStripLabel searchLabel = new ToolStripLabel("CMD :");
        ToolStripTextBox txtTextbox = new ToolStripTextBox();
        ToolStripButton btnFind = new ToolStripButton("Run");
        try
        {
            txtTextbox.Width = width;
            sta.Items.Insert(position, searchLabel);
            sta.Items.Insert(position + 1, txtTextbox);
            sta.Items.Insert(position + 2, btnFind);
        }
        catch (Exception ex)
        {
            return false;
            throw ex;
        }
        return true;
    }


    public static string sqlString(string str)
    {
        return " N'" + (str ?? "").Replace("'", "''") + "' ";
    }

    public static string sqlBit(bool b)
    {
        if (b == false)
        {
            return "0";
        }
        else
        {
            return "1";
        }
    }
    public static string sqlStringNull(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return "NULL";
        }
        else
        {
            return " N'" + (str ?? "").Replace("'", "''") + "' ";
        }
    }

    public static string sqlStringA(string str)
    {
        return " '" + (str ?? "").Replace("'", "''") + "' ";
    }

    public static string sqlString(TextBox txt)
    {
        return sqlString(txt.Text);
    }

    public static string sqlBit(CheckBox b)
    {
        return sqlBit(b.Checked);
    }
    public static string sqlStringNull(TextBox txt)
    {
        return sqlStringNull(txt.Text);
    }

    public static string sqlStringA(TextBox txt)
    {
        return sqlStringA(txt.Text);
    }
    public static string sqlGender(bool rad)
    {
        if (rad == true)
        {
            return "N'M'";
        }
        else
        {
            return "N'F'";
        }
    }
    public static string sqlGender(RadioButton rad)
    {
        if (rad.Checked == true)
        {
            return "N'M'";
        }
        else
        {
            return "N'F'";
        }
    }
    public static string sqlDate(System.DateTime dt)
    {
        return "'" + dt.ToString("yyyy-MM-dd") + "'";
    }
    public static string sqlDate(DateTimePicker dt)
    {
        return "'" + dt.Value.ToString("yyyy-MM-dd") + "'";
    }
    public static string sqlCombo(ComboBox cbo)
    {
        if (cbo.SelectedIndex == -1)
            return "NULL";
        return cbo.SelectedValue.ToString();
    }
    public static string sqlInt(string num)
    {
        try
        {
            int nums = Convert.ToInt32(num);
            return num;
        }
        catch (Exception ex)
        {
            return "NULL";
            throw ex;
        }
    }
    public static string sqlInt(TextBox num)
    {
        try
        {
            int nums = Convert.ToInt32(num.Text);
            return num.Text;
        }
        catch (Exception ex)
        {
            return "NULL";
            throw ex;
        }
    }
    public static decimal getMinvalue(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        else
        {
            string str = null;
            str = "0.";
            for (int i = 0; i <= num - 1; i++)
            {
                if (i == num - 1)
                {
                    str = str + "1";
                }
                else
                {
                    str = str + "0";
                }
            }
            return Convert.ToDecimal(str);
        }
    }
}