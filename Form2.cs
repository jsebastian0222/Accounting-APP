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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_orderinput_Click(object sender, EventArgs e)
        {
           Form3 inputorder = new Form3();
            inputorder.Show();
            this.Close();
        }
        public void setButtonVisible(Boolean cek)
        {
            this.button_financialreport.Visible = cek;
        }

        private void button_backmainmenu_Click(object sender, EventArgs e)
        {
            Form1 loginpage = new Form1();
            loginpage.Show();
            this.Close();

        }

        private void button_maintenancecatalog_Click(object sender, EventArgs e)
        {
            Form5 maintenancecatalog = new Form5();
            maintenancecatalog.Show();
            this.Close();
        }

        private void button_maintenancepromo_Click(object sender, EventArgs e)
        {
            Form7 maintenancepromo = new Form7();
            maintenancepromo.Show();
            this.Close();
        }

        private void button_transactionhistory_Click(object sender, EventArgs e)
        {
            Form8 historitransaksi = new Form8();
            historitransaksi.Show();
            this.Close();
        }

        private void button_expenditureinput_Click(object sender, EventArgs e)
        {
            Form9 inputpengeluaran = new Form9();
            inputpengeluaran.Show();
            this.Close();
        }

        private void button_financialreport_Click(object sender, EventArgs e)
        {
            Form12 inputpembukuan = new Form12();
            inputpembukuan.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
