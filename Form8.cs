using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Media.Media3D;
using System.Collections;
using System.Globalization;
namespace ACCOUNTING_APP
{
    public partial class Form8 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string connectionstring;
        string sqlquery;
        string connection;
        DataTable dthistori = new DataTable();
        DataTable dthistorimonth = new DataTable();
        public Form8()
        {

            InitializeComponent();
            try
            {
                string connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                string query = "select nama_service as 'nama service' , service_id as 'id service'from service where status_del = 'F';";
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button_backhistoritransaksi_Click(object sender, EventArgs e)
        {
            Form2 mainmenu = new Form2();
            mainmenu.Show();
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button_submithistori_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_month_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void Form8_Load_1(object sender, EventArgs e)
        {

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            dthistori.Clear();
            conn = new MySqlConnection(connectionstring);
            if (cbox_year.SelectedIndex == 0 && cbox_month.SelectedIndex == 0)
            {
                dthistori.Clear();
                connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                sqlquery = "select penjualan_id, tgl_penjualan, harga_penjualan, promo, harga_penjualan*promo  as Total from Penjualan where status_del = 'F' ";
                cmd = new MySqlCommand(sqlquery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dthistori);
                dgv_historitransaksi.DataSource = dthistori;

            }
            else if (cbox_year.SelectedIndex != 0 && cbox_month.SelectedIndex == 0)
            {
                dthistori.Clear();
                connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                sqlquery = $"select penjualan_id, tgl_penjualan, harga_penjualan, promo, harga_penjualan*promo  as Total from Penjualan where status_del = 'F' and year(tgl_penjualan) = '{cbox_year.SelectedItem.ToString()}'";
                cmd = new MySqlCommand(sqlquery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dthistori);
                dgv_historitransaksi.DataSource = dthistori;

            }
            else if (cbox_year.SelectedIndex != 0 && cbox_month.SelectedIndex != 0)
            {
                dthistori.Clear();
                connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                sqlquery = $"select penjualan_id, tgl_penjualan, harga_penjualan, promo, harga_penjualan*promo  as Total from Penjualan where status_del = 'F' and year(tgl_penjualan) = '{cbox_year.SelectedItem.ToString()}' and month(tgl_penjualan) = '{cbox_month.SelectedIndex.ToString()}'";
                cmd = new MySqlCommand(sqlquery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dthistori);
                dgv_historitransaksi.DataSource = dthistori;

            }
            else if (cbox_year.SelectedIndex == 0 && cbox_month.SelectedIndex != 0)
            {
                dthistori.Clear();
                connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                sqlquery = $"select penjualan_id, tgl_penjualan, harga_penjualan, promo, harga_penjualan*promo  as Total from Penjualan where status_del = 'F' and month(tgl_penjualan) = '{cbox_month.SelectedIndex.ToString()}'";
                cmd = new MySqlCommand(sqlquery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dthistori);
                dgv_historitransaksi.DataSource = dthistori;

            }
            else
            {
                dthistori.Clear();
                connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                sqlquery = "select penjualan_id, tgl_penjualan, harga_penjualan, promo, harga_penjualan*promo  as Total from Penjualan where status_del = 'F' ";
                cmd = new MySqlCommand(sqlquery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dthistori);
                dgv_historitransaksi.DataSource = dthistori;
            }
            this.dgv_historitransaksi.Columns["penjualan_id"].Visible = false;
        }
    }
}


