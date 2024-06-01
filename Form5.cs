using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCOUNTING_APP
{
    public partial class Form5 : Form
    {
        string mysqlquary;
        string mysqlconnection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
        MySqlConnection myconnection;
        MySqlCommand mycommand;
        MySqlDataAdapter myadapter;
        MySqlDataReader myreader;
        DataTable dthidden = new DataTable();
        DataTable dt = new DataTable();

        string idselected;
        public Form5()
        {
            InitializeComponent();
            GetDataFromSQL();
        }
        private void GetDataFromSQL()
        {
            dt.Clear();

            mysqlquary = $"select service_id , nama_service as 'Nama Service',harga_service 'Harga Service' from service where status_del = 'F';";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            myadapter.Fill(dt);
            
            dgv_addcatalog.DataSource = dt;
            dgv_addcatalog.Columns["service_id"].Visible = false;
        }

        private void button_backaddcatalog_Click(object sender, EventArgs e)
        {
            Form2 mainmenu= new Form2();
            mainmenu.Show();
            this.Close();
        }

        private void button_nextpage_Click(object sender, EventArgs e)
        {
            Form6 updatecatalog = new Form6();
            updatecatalog.Show();
            this.Close();
        }

        private void dgv_addcatalog_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int max = dgv_addcatalog.RowCount -1;
            int counter = 0;
            foreach (DataGridViewRow row in dgv_addcatalog.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 2) 
                    {
    
                        myconnection.Open();
                        mysqlquary = $"update Service set harga_service = '{cell.Value.ToString()}' where service_id = '{dt.Rows[counter][0].ToString()}';";
                        mycommand = new MySqlCommand(mysqlquary, myconnection);
                        myreader = mycommand.ExecuteReader();
                        myconnection.Close();
                        counter++;
                        if (max <= counter)
                        {
                            break;
                        }
                    }
                    
                }
                if (max <= counter)
                {
                    break;
                }
            }
            GetDataFromSQL();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtbox_namaserviceaddcatalog.Text != "" && txtbox_hargaaddcatalog.Text != "")
            {
                myconnection.Open();
                mysqlquary = $"insert into Service (nama_service,harga_service,status_del) values ('{txtbox_namaserviceaddcatalog.Text}','{txtbox_hargaaddcatalog.Text}','F');";
                mycommand = new MySqlCommand(mysqlquary, myconnection);
                myreader = mycommand.ExecuteReader();
                myconnection.Close();
            }
            GetDataFromSQL();
        }

        private void dgv_addcatalog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idselected = dt.Rows[dgv_addcatalog.CurrentCell.RowIndex][0].ToString();
            //error
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            myconnection.Open();
            mysqlquary = $"update Service set status_del = 'T' where service_id = '{idselected}';";
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myreader = mycommand.ExecuteReader();
            myconnection.Close();
            GetDataFromSQL();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
