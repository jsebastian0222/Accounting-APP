using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCOUNTING_APP
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button_backupdatecatalog_Click(object sender, EventArgs e)
        {
            Form5 maintenancecatalog = new Form5();
            maintenancecatalog.Show();
            this.Close();
        }
    }
}
