using MySql.Data.MySqlClient;
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
    public partial class Form12 : Form
    {
        string[] data1 = { "-", "-", "-", "-", "-", "-" };
        string[] data2 = { "-", "-", "-", "-", "-", "-" };
        string[] data3 = { "-", "-", "-", "-", "-", "-" };
        string[] data4 = { "", "2023", "2024", "2025", "2026", "2027", "2028" };
        string[] data5 = { "00", "01", "02", "03", "04", "06", "07", "08", "09", "10", "11", "12" };
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dtshow = new DataTable();
        DataTable dtshow2 = new DataTable();
        MySqlDataReader reader;
        public Form12()
        {
            InitializeComponent();
            GetDataFromSQL();
            ShowDisplay();
        }
        private void ShowDisplay()
        {
            dgvmoney.DataSource = dtshow;
            dgvmoney.BackgroundColor = Color.White;
            dgvmoney.RowHeadersVisible = false;

            dgvtot.DataSource = dtshow2;
            dgvtot.BackgroundColor = Color.White;
            dgvtot.RowHeadersVisible = false;
        }
        private void GetDataFromSQL()
        {

            try
            {
                string connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                string query = "select a.tgl_penjualan as 'Tanggal',  a.harga_penjualan*a.promo as 'Profit', \"-\" as 'Loss' from penjualan a union all select tgl_pengeluaran ,  \"-\" ,harga_pengeluaran*qty from pengeluaran; ";
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            try
            {
                string connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                string query = "select \"Total Profit:\" as '',cast(sum(a.harga_penjualan*a.promo) as CHAR) as 'Profit' , '' as 'Loss' from penjualan a union all select 'Total Pengeluaran','',cast(sum(b.harga_pengeluaran*b.qty)as CHAR) from pengeluaran b ;";
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt2);
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button_backjurnalumum_Click(object sender, EventArgs e)
        {
            Form2 optionreport = new Form2();
            optionreport.Show();
            this.Close();
        }

        private void cbox_year_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cbox_moon_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            dtshow.Clear();
            dtshow2.Clear();

            if (cbox_year.SelectedIndex == 0 && cbox_moon.SelectedIndex == 0)
            {
                string connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                string query = "select a.tgl_penjualan as 'Tanggal',  a.harga_penjualan*a.promo as 'Profit', \"-\" as 'Loss' from penjualan a where a.status_del = 'F' union all select tgl_pengeluaran ,  \"-\" ,harga_pengeluaran*qty from pengeluaran where status_del = 'F' order by 1; ";
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dtshow);

                connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                query = "select \"Total Profit:\" as '',cast(sum(a.harga_penjualan*a.promo) as CHAR) as 'Profit' , '' as 'Loss' from penjualan a union all select 'Total Pengeluaran','',cast(sum(b.harga_pengeluaran*b.qty)as CHAR) from pengeluaran b ;";
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dtshow2);
            }
            else if (cbox_year.SelectedIndex != 0 && cbox_moon.SelectedIndex == 0)
            {
                string connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                string query = $"select a.tgl_penjualan as 'Tanggal',  a.harga_penjualan*a.promo as 'Profit', \"-\" as 'Loss' from penjualan a where a.tgl_penjualan >= str_to_date('01-01-{data4[cbox_year.SelectedIndex]}','%d-%m-%Y') and a.tgl_penjualan <= str_to_date('31-12-{data4[cbox_year.SelectedIndex]}','%d-%m-%Y') and a.status_del = 'F' union all select tgl_pengeluaran ,  \"-\" ,harga_pengeluaran*qty from pengeluaran where status_del = 'F' and tgl_pengeluaran >= str_to_date('01-01-{data4[cbox_year.SelectedIndex]}','%d-%m-%Y') and tgl_pengeluaran <= str_to_date('31-12-{data4[cbox_year.SelectedIndex]}','%d-%m-%Y') order by 1; ";
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dtshow);

                connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                query = $"select \"Total Profit:\" as '',cast(ifnull(sum(a.harga_penjualan*promo),'-') as CHAR) as 'Profit' , '' as 'Loss' from penjualan a where a.tgl_penjualan >= str_to_date('01-{data5[cbox_moon.SelectedIndex]}-{data4[cbox_year.SelectedIndex]}','%d-%m-%Y') and a.tgl_penjualan <= str_to_date('31-{data5[cbox_moon.SelectedIndex]}-{data4[cbox_year.SelectedIndex]}','%d-%m-%Y') and a.status_del = 'F' union all select 'Total Pengeluaran','',cast(ifnull(sum(harga_pengeluaran*qty),'-')as CHAR) from pengeluaran where status_del = 'F' and tgl_pengeluaran >= str_to_date('01-01-{data4[cbox_year.SelectedIndex]}','%d-%m-%Y') and tgl_pengeluaran <= str_to_date('31-12-{data4[cbox_year.SelectedIndex]}','%d-%m-%Y');";
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dtshow2);
            }
            else if (cbox_year.SelectedIndex != 0 && cbox_moon.SelectedIndex != 0)
            {
                string connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                string query = $"select a.tgl_penjualan as 'Tanggal',  a.harga_penjualan*a.promo as 'Profit', \"-\" as 'Loss' from penjualan a where a.tgl_penjualan >= str_to_date('01-{cbox_moon.SelectedIndex}-{data4[cbox_year.SelectedIndex]}','%d-%m-%Y') and a.tgl_penjualan <= str_to_date('31-{cbox_moon.SelectedIndex}-{data4[cbox_year.SelectedIndex]}','%d-%m-%Y') and a.status_del = 'F' union all select tgl_pengeluaran ,  \"-\" ,harga_pengeluaran*qty from pengeluaran where status_del = 'F' and tgl_pengeluaran >= str_to_date('01-{cbox_moon.SelectedIndex}-{data4[cbox_year.SelectedIndex]}','%d-%m-%Y') and tgl_pengeluaran <= str_to_date('31-{cbox_moon.SelectedIndex}-{data4[cbox_year.SelectedIndex]}','%d-%m-%Y') order by 1; ";
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dtshow);

                connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                query = $"select \"Total Profit:\" as '',cast(ifnull(sum(a.harga_penjualan*promo),'-') as CHAR) as 'Profit' , '' as 'Loss' from penjualan a where a.tgl_penjualan >= str_to_date('01-{cbox_moon.SelectedIndex}-{data4[cbox_year.SelectedIndex]}','%d-%m-%Y') and a.tgl_penjualan <= str_to_date('31-{cbox_moon.SelectedIndex}-{data4[cbox_year.SelectedIndex]}','%d-%m-%Y') and a.status_del = 'F' union all select 'Total Pengeluaran','',cast(ifnull(sum(harga_pengeluaran*qty),'-')as CHAR) from pengeluaran where status_del = 'F' and tgl_pengeluaran >= str_to_date('01-{cbox_moon.SelectedIndex}-{data4[cbox_year.SelectedIndex]}','%d-%m-%Y') and tgl_pengeluaran <= str_to_date('31-{cbox_moon.SelectedIndex}-{data4[cbox_year.SelectedIndex]}','%d-%m-%Y');";
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dtshow2);
            }
            else if (cbox_year.SelectedIndex == 0 && cbox_moon.SelectedIndex != 0)
            {

                string connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                string query = $"select a.tgl_penjualan as 'Tanggal',  a.harga_penjualan*a.promo as 'Profit', \"-\" as 'Loss' from penjualan a where MONTH(a.tgl_penjualan) = '{cbox_moon.SelectedIndex.ToString()}' and a.status_del = 'F' union all select tgl_pengeluaran ,  \"-\" ,harga_pengeluaran*qty from pengeluaran where status_del = 'F' and MONTH(tgl_pengeluaran) = '{cbox_moon.SelectedIndex.ToString()}' order by 1; ";
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dtshow);

                connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                query = $"select \"Total Profit:\" as '',cast(ifnull(sum(a.harga_penjualan*promo),'-') as CHAR) as 'Profit' , '' as 'Loss' from penjualan a where MONTH(a.tgl_penjualan) = '{cbox_moon.SelectedIndex.ToString()}' and a.status_del = 'F' and year(tgl_penjualan) = '{cbox_year.SelectedItem.ToString()}' union all select 'Total Pengeluaran','',cast(ifnull(sum(harga_pengeluaran*qty),'-')as CHAR) from pengeluaran where status_del = 'F' and MONTH(tgl_pengeluaran) = '{cbox_moon.SelectedIndex.ToString()}';";
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dtshow2);
            }
            else
            {
                dtshow = dt;
                dtshow2 = dt2;
            }
            ShowDisplay();
        }
    }
}
