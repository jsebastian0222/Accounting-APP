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
    public partial class Form3 : Form
    {
        string mysqlconnection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
        string[] data1 = { "-", "-", "-", "-", "-", "-", "-" };
        string[] data2 = { "-", "-", "-", "-", "-", "-", "-" };
        string[] data3 = { "-", "-", "-", "-", "-", "-", "-" };
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        DataTable dtharga = new DataTable();
        MySqlDataReader reader;

        public Form3()
        {
            InitializeComponent();
            changeorder();


            try
            {
                string connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
                conn = new MySqlConnection(connection);
                string query = "select nama_service as 'nama service' , service_id as 'id service'from service where status_del = 'F';";
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                cbox_jenisservice.DataSource = dt;
                cbox_jenisservice.DisplayMember = "nama service";
                cbox_jenisservice.ValueMember = "id service";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 formreceipt = new Form4(data1);
            formreceipt.ShowDialog();
            fuckyou();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_backorder_Click(object sender, EventArgs e)
        {
            Form2 mainmenu = new Form2();
            mainmenu.Show();
            this.Close();
        }
        private void changeorder()
        {
            label_printplat1.Text = data1[0];
            label_printjenismobil1.Text = data1[1];
            label_printjenisservice1.Text = data1[2];
            label_printtanggal1.Text = data1[3];
            label_printharga1.Text = data1[4];
            label_printestimasi1.Text = data1[5];

            label_printplat2.Text = data2[0];
            label_printjenismobil2.Text = data2[1];
            label_printjenisservice2.Text = data2[2];
            label_printtanggal2.Text = data2[3];
            label_printharga2.Text = data2[4];
            label_printestimasi2.Text = data2[5];

            label_printplat3.Text = data3[0];
            label_printjenismobil3.Text = data3[1];
            label_printjenisservice3.Text = data3[2];
            label_printtanggal3.Text = data3[3];
            label_printharga3.Text = data3[4];
            label_printestimasi3.Text = data3[5];
        }
        private void button_input_Click(object sender, EventArgs e)
        {

            if (txtbox_plat.Text == "" || txtbox_jenismobil.Text == "" || txtbox_harga1.Text == "" || txtbox_estimasi.Text == "")
            {
                MessageBox.Show("ada yang kosonggggg");
            }
            else
            {
                if (data1[1] == "-")
                {
                    string plat = txtbox_plat.Text;
                    label_printplat1.Text = plat;
                    data1[0] = plat;
                    string jenismobil = txtbox_jenismobil.Text;
                    label_printjenismobil1.Text = jenismobil;
                    data1[1] = jenismobil;
                    string jenisservice = cbox_jenisservice.Text;
                    label_printjenisservice1.Text = jenisservice;
                    data1[2] = jenisservice;
                    string tanggal = dtp_inputorder.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
                    label_printtanggal1.Text = tanggal;
                    data1[3] = tanggal;
                    string harga = txtbox_harga1.Text;
                    label_printharga1.Text = harga;
                    data1[4] = harga;
                    string estimasi = txtbox_estimasi.Text;
                    label_printestimasi1.Text = estimasi;
                    data1[5] = estimasi;
                    data1[6] = cbox_jenisservice.SelectedValue.ToString();
                    string apa = $"insert into Penjualan value (',{data1[3]}',{data1[3]},'{data1[4]}');";
                }
                else if (data2[1] == "-")
                {
                    string plat = txtbox_plat.Text;
                    label_printplat2.Text = plat;
                    data2[0] = plat;
                    string jenismobil = txtbox_jenismobil.Text;
                    label_printjenismobil2.Text = jenismobil;
                    data2[1] = jenismobil;
                    string jenisservice = cbox_jenisservice.Text;
                    label_printjenisservice2.Text = jenisservice;
                    data2[2] = jenisservice;
                    string tanggal = dtp_inputorder.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
                    label_printtanggal2.Text = tanggal;
                    data2[3] = tanggal;
                    string harga = txtbox_harga1.Text;
                    label_printharga2.Text = harga;
                    data2[4] = harga;
                    string estimasi = txtbox_estimasi.Text;
                    label_printestimasi2.Text = estimasi;
                    data2[5] = estimasi;
                    data2[6] = cbox_jenisservice.SelectedValue.ToString();
                }
                else if (data3[1] == "-")
                {
                    string plat = txtbox_plat.Text;
                    label_printplat3.Text = plat;
                    data3[0] = plat;
                    string jenismobil = txtbox_jenismobil.Text;
                    label_printjenismobil3.Text = jenismobil;
                    data3[1] = jenismobil;
                    string jenisservice = cbox_jenisservice.Text;
                    label_printjenisservice3.Text = jenisservice;
                    data3[2] = jenisservice;
                    string tanggal = dtp_inputorder.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
                    label_printtanggal3.Text = tanggal;
                    data3[3] = tanggal;
                    string harga = txtbox_harga1.Text;
                    label_printharga3.Text = harga;
                    data3[4] = harga;
                    string estimasi = txtbox_estimasi.Text;
                    label_printestimasi3.Text = estimasi;
                    data3[5] = estimasi;
                    data3[6] = cbox_jenisservice.SelectedValue.ToString();
                }
                else
                {
                    MessageBox.Show("sudah Penuh");
                }
            }

            txtbox_plat.Text = "";
            txtbox_jenismobil.Text = "";
            txtbox_harga1.Text = "";
            txtbox_estimasi.Text = "";



        }

        private void button_cancel1_Click(object sender, EventArgs e)
        {
            fuckyou();
        }

        private void button_cancel2_Click(object sender, EventArgs e)
        {
            fuckyou1();
        }

        private void button_cancel3_Click(object sender, EventArgs e)
        {
            fuckyou2();
        }

        private void button_printreceipt2_Click(object sender, EventArgs e)
        {
            Form4 formreceipt = new Form4(data2);
            formreceipt.ShowDialog();
            fuckyou1();
        }

        private void button_printreceipt3_Click(object sender, EventArgs e)
        {
            Form4 formreceipt = new Form4(data3);
            formreceipt.ShowDialog();
            fuckyou2();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cbox_jenisservice_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtharga.Clear();
            string connection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
            conn = new MySqlConnection(connection);
            string query = $"select harga_service as 'harga service' from service where service_id = '{cbox_jenisservice.SelectedValue.ToString()}';";
            cmd = new MySqlCommand(query, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtharga);

            txtbox_harga1.Text = "";
            txtbox_harga1.Text = dtharga.Rows[0][0].ToString();
        }

        private void fuckyou()
        {
            label_printplat1.Text = "-";
            label_printjenismobil1.Text = "-";
            label_printjenisservice1.Text = "-";
            label_printtanggal1.Text = "-";
            label_printharga1.Text = "-";
            label_printestimasi1.Text = "-";

            for (int i = 0; i < 6; i++)
            {
                data1[i] = data2[i];
            }
            for (int i = 0; i < 6; i++)
            {
                data2[i] = data3[i];
            }
            for (int i = 0; i < 6; i++)
            {
                data3[i] = "-";
            }
            changeorder();
        }
        private void fuckyou1()
        {
            label_printplat2.Text = "-";
            label_printjenismobil2.Text = "-";
            label_printjenisservice2.Text = "-";
            label_printtanggal2.Text = "-";
            label_printharga2.Text = "-";
            label_printestimasi2.Text = "-";

            for (int i = 0; i < 6; i++)
            {
                data2[i] = data3[i];
            }
            for (int i = 0; i < 6; i++)
            {
                data3[i] = "-";
            }
            changeorder();
        }
        private void fuckyou2()
        {
            label_printplat3.Text = "-";
            label_printjenismobil3.Text = "-";
            label_printjenisservice3.Text = "-";
            label_printtanggal3.Text = "-";
            label_printharga3.Text = "-";
            label_printestimasi3.Text = "-";

            changeorder();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
