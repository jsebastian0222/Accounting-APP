using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCOUNTING_APP
{
    public partial class Form7 : Form
    {
        string mysqlquary;
        string mysqlconnection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
        MySqlConnection myconnection;
        MySqlCommand mycommand;
        MySqlDataAdapter myadapter;
        MySqlDataReader myreader;
        DataTable dthidden = new DataTable();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dtpromo = new DataTable();

        string tanggal, tanggalend;

        public Form7()
        {
            InitializeComponent();
            GetData();
            GetSQLData();
        }
        private void GetSQLData()
        {
            dtpromo.Clear();
            mysqlquary = $"select promo_id, promo_name from promo where status_del = 'F' and curdate() < promo_end;";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            myadapter.Fill(dtpromo);
            cbox_ongoing.DataSource = dtpromo;
            cbox_ongoing.DisplayMember = "promo_name";
            cbox_ongoing.ValueMember = "promo_id";
        }

        private void button_backmaintenancepromo_Click(object sender, EventArgs e)
        {
            Form2 mainmenu = new Form2();
            mainmenu.Show();
            this.Close();
        }
        private void GetData()
        {
            tanggal = dtp_startdatepromo.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
            tanggalend = dtp_enddatepromo.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
        }
        private void CheckData()
        {
            mysqlquary = $"select if(curdate() between promo_start and promo_end, 'true', 'false') as is_ongoing from promo where status_del = 'F' order by promo_end desc limit 1;";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            myadapter.Fill(dt);

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            myconnection.Open();
            mysqlquary = $"update promo set status_del = 'T' where promo_id = '{cbox_ongoing.SelectedValue.ToString()}';";
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myreader = mycommand.ExecuteReader();
            myconnection.Close();
            GetSQLData();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            txtbox_inputpromo2.Text = "";
            txtbox_jenispromo2.Text = "";
        }

        private void button_submitmaintenancepromo_Click(object sender, EventArgs e)
        {
            GetData();
            CheckData();
            if (dt.Rows.Count != 0)
            {
                if(dt.Rows[0]["is_ongoing"].ToString() == "false" && dtp_startdatepromo.Value < dtp_enddatepromo.Value)
                {
                    myconnection.Open();
                    mysqlquary = $"insert into Promo (promo_name, promo_discount, promo_start, promo_end, status_del) values ('{txtbox_inputpromo2.Text}', '{txtbox_jenispromo2.Text}', str_to_date('{tanggal}','%d-%m-%Y'), str_to_date('{tanggalend}','%d-%m-%Y'), 'F');";
                    mycommand = new MySqlCommand(mysqlquary, myconnection);
                    myreader = mycommand.ExecuteReader();
                    myconnection.Close();
                }
                else if (dtp_startdatepromo.Value > dtp_enddatepromo.Value)
                {
                    MessageBox.Show("Start/End Date Error");
                }
                else if (dt.Rows[0][0].ToString() == "false")
                {
                    MessageBox.Show("Ongoing Promo");
                }
                else
                {
                    MessageBox.Show("Unknown Error");
                }
            }
            else
            {
                myconnection.Open();
                mysqlquary = $"insert into Promo (promo_name, promo_discount,promo_start, promo_end, status_del) values ('{txtbox_inputpromo2.Text}','{txtbox_jenispromo2.Text}',str_to_date('{tanggal}','%d-%m-%Y'),str_to_date('{tanggalend}','%d-%m-%Y'),'F');";
                mycommand = new MySqlCommand(mysqlquary, myconnection);
                myreader = mycommand.ExecuteReader();
                myconnection.Close();
            }
           
        }
    }
}
