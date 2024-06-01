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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button_backbukubesar_Click(object sender, EventArgs e)
        {
            Form10 optionreport = new Form10();
            optionreport.Show();
            this.Close();
        }
    }
}
