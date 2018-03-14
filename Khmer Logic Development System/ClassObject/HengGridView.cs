using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;


public class HengGridView : DataGridView
{
    public HengGridView()
    {
        this.ApplyDefaultStyle();
        this.KeyDown += new KeyEventHandler(this.MyGridVeiw_KeyDown);
        this.CellDoubleClick += new DataGridViewCellEventHandler(this.MyGridVeiw_CellDoubleClick);
        this.EnableHeadersVisualStyles = false;
    }

    public void ApplyDefaultStyle()
    {
        //  Me.RowHeadersVisible = False
        // Me.AllowUserToAddRows = False
        // Me.AllowUserToDeleteRows = False
        this.AllowUserToResizeRows = false;
        this.DefaultCellStyle.Font = new Font("Khmer OS Siemreap", 8);
        this.RowTemplate.DefaultCellStyle.Font = new Font("Khmer OS Siemreap", 8);
        this.CellBorderStyle = DataGridViewCellBorderStyle.None;
        DataGridViewCellStyle tmp = new DataGridViewCellStyle();
        tmp.BackColor = Color.WhiteSmoke;
        this.AlternatingRowsDefaultCellStyle = tmp;
        this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 205, 239);
        this.DefaultCellStyle.SelectionForeColor = Color.Black;
        this.ColumnHeadersDefaultCellStyle.Font = new Font("Khmer OS Siemreap", 8);
        this.RowTemplate.Height = 27;
        this.BackgroundColor = Color.White;
    }


    private void MyGridVeiw_KeyDown(object sender, KeyEventArgs e)
    {

    }

    private void MyGridVeiw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}

