using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;

namespace ACCOUNTING_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void InitializeWpfVideoPlayer()
        {
            
        }
        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Form2 formmainmenu = new Form2();
            
            if (txtbox_username.Text == "owner" && txtbox_password.Text == "ss")
            {
                formmainmenu.Show();
                this.Hide();
            }
            
            else if(txtbox_username.Text == "kasir" && txtbox_password.Text == "ss")
            {
                formmainmenu.Show();
                this.Hide();
                formmainmenu.setButtonVisible(false);
            }
            else if(txtbox_username.Text == "finance" && txtbox_password.Text == "ss")
            {
                formmainmenu.Show();
                this.Hide();
                formmainmenu.setButtonVisible(false);
            }
            else
            {
                MessageBox.Show("salah");
            }
        }
    }
}
