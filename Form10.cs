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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button_backfinancialreport_Click(object sender, EventArgs e)
        {
            Form2 mainmenu = new Form2();
            mainmenu.Show();
            this.Close();
        }

        private void button_jurnalumum_Click(object sender, EventArgs e)
        {
            Form12 jurnalumum = new Form12();
            jurnalumum.Show();
            this.Close();
        }

        private void button_bukubesar_Click(object sender, EventArgs e)
        {
            Form11 bukubesar = new Form11();
            bukubesar.Show();
            this.Close();
        }
    }
}
