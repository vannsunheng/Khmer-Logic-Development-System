using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khmer_Logic_Development_System
{
    public partial class Dashboard : Form, IPage
    {
        public Dashboard()
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblEnglishName.Text = Setting.CompanyEngName;
            lblKhmerName.Text = Setting.CompanyName;
        }
    }
}
