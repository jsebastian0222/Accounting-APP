using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml;
using System.Xml.Linq;

namespace ACCOUNTING_APP
{
    public partial class Form9 : Form
    {
        string mysqlquary;
        string mysqlconnection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
        int saveslot;
        MySqlCommand mycommand;
        MySqlDataAdapter myadapter;
        MySqlDataReader myreader;
        DataTable dtgetpromo = new DataTable();
        DataTable dt = new DataTable();


        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlConnection myconnection;
        string connectionstring;
        string sqlquery;
        string connection;
        DataTable dthistori = new DataTable();
        DataTable dthistorimonth = new DataTable();

        string[] data = { "Utilitas","Alat dan Bahan","Insiden","Layanan","Lain-Lain"};
        public Form9()
        {
            InitializeComponent();
            GetDataFromSQL();
            
        }

        private void button_backinputpengeluaran_Click(object sender, EventArgs e)
        {
            Form2 mainmenu = new Form2();
            mainmenu.Show();
            this.Close();
        }

        private void GetDataFromSQL()
        {

            try
            {


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void cbox_month_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void button_inputpengeluaran2_Click(object sender, EventArgs e)
        {
            myconnection = new MySqlConnection(mysqlconnection);
            string jenis = data[cbox_jenispengeluaran.SelectedIndex];
            string name = txtbox_namapengeluaran.Text;
            string harga = txtbox_hargapengeluaran.Text;
            string qty = txtbox_jumlahpengeluaran.Text;
            string tanggal = dtp1.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);

            if (name != "" && harga != "" && qty != ""&& jenis != "") 
            {
                myconnection.Open();
                mysqlquary = $"insert into Pengeluaran (jenis_pengeluaran,nama_pengeluaran,tgl_pengeluaran,harga_pengeluaran,qty,status_del) values (  '{jenis}', '{name}',str_to_date('{tanggal}','%d-%m-%Y'),'{harga}','{qty}', 'F');";
                mycommand = new MySqlCommand(mysqlquary, myconnection);
                myreader = mycommand.ExecuteReader();
                myconnection.Close();
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }



        }
        private void eatshit()
        {
            cbox_jenispengeluaran.SelectedIndex = -1;
            txtbox_namapengeluaran.Text = "";
            txtbox_hargapengeluaran.Text = "";
            txtbox_jumlahpengeluaran.Text = "";
        }

        private void Form9_Load(object sender, EventArgs e)
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
                sqlquery = $"select tgl_pengeluaran,pengeluaran_id, jenis_pengeluaran, nama_pengeluaran, harga_pengeluaran*qty from Pengeluaran where status_del = 'F';";
                cmd = new MySqlCommand(sqlquery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dthistori);
                dgv_inputpengeluaran.DataSource = dthistori;

            }
            else if (cbox_year.SelectedIndex != 0 && cbox_month.SelectedIndex == 0)
            {
                dthistori.Clear();
                connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                sqlquery = $"select tgl_pengeluaran,pengeluaran_id, jenis_pengeluaran, nama_pengeluaran, harga_pengeluaran*qty from Pengeluaran where status_del = 'F' and year(tgl_pengeluaran) = '{cbox_year.SelectedItem.ToString()}';";
                cmd = new MySqlCommand(sqlquery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dthistori);
                dgv_inputpengeluaran.DataSource = dthistori;

            }
            else if (cbox_year.SelectedIndex != 0 && cbox_month.SelectedIndex != 0)
            {
                dthistori.Clear();
                connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                sqlquery = $"select tgl_pengeluaran,pengeluaran_id, jenis_pengeluaran, nama_pengeluaran, harga_pengeluaran*qty from Pengeluaran where status_del = 'F' and year(tgl_pengeluaran) = '{cbox_year.SelectedItem.ToString()}' and month(tgl_pengeluaran) = '{cbox_month.SelectedIndex.ToString()}';";
                cmd = new MySqlCommand(sqlquery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dthistori);
                dgv_inputpengeluaran.DataSource = dthistori;

            }
            else if (cbox_year.SelectedIndex == 0 && cbox_month.SelectedIndex != 0)
            {
                dthistori.Clear();
                connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                sqlquery = $"select tgl_pengeluaran,pengeluaran_id, jenis_pengeluaran, nama_pengeluaran, harga_pengeluaran*qty from Pengeluaran where status_del = 'F' and month(tgl_pengeluaran) = '{cbox_month.SelectedIndex.ToString()}';";
                cmd = new MySqlCommand(sqlquery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dthistori);
                dgv_inputpengeluaran.DataSource = dthistori;

            }
            else
            {
                dthistori.Clear();
                connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                sqlquery = $"select tgl_pengeluaran,pengeluaran_id, jenis_pengeluaran, nama_pengeluaran, harga_pengeluaran*qty from Pengeluaran where status_del = 'F';";
                cmd = new MySqlCommand(sqlquery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dthistori);
                dgv_inputpengeluaran.DataSource = dthistori;
            }
            this.dgv_inputpengeluaran.Columns["pengeluaran_id"].Visible = false;
        }

        private void button_deleteinputpengeluaran_Click(object sender, EventArgs e)
        {

        }
    }
}


