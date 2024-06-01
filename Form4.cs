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

    public partial class Form4 : Form
    {
        string mysqlquary;
        string mysqlconnection = "server=localhost;user=root;pwd=2004-05-07;database=db_sad";
        int saveslot;
        MySqlConnection myconnection;
        MySqlCommand mycommand;
        MySqlDataAdapter myadapter;
        MySqlDataReader myreader;
        DataTable dtgetpromo = new DataTable();
        DataTable dt = new DataTable();

        string  jenisservice, tanggal, harga, promo, promoid;
        int hargaint, promoint,total;
        double promodoubleval;
        
        String[] Data = { "", "", "","", "", "", "" };
        public Form4(String[] Data)
        {
            InitializeComponent();
            this.Data = Data;
            getpromo();
            Testnamainput();
            InputDatatoSQL();
        }
        private void getpromo()
        {
            mysqlquary = $"select promo_id, promo_discount from promo where status_del = 'F' and if(curdate()<=promo_end and curdate()>=promo_start  ,\"true\",\"false\") = \"true\" limit 1;";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            myadapter.Fill(dtgetpromo);

            if (dtgetpromo.Rows.Count == 0)
            {
                promo = "0";
                promoid = "0";
            }
            else
            {
                promo = Convert.ToString(dtgetpromo.Rows[0][1].ToString());
                promoid = Convert.ToString(dtgetpromo.Rows[0][0].ToString());
            }
            

        }
        private void InputDatatoSQL()
        {
            myconnection.Open();
            mysqlquary = $"insert into Penjualan (tgl_penjualan,harga_penjualan,promo,merk_mobil,plat_mobil,service_id,status_del) values ( str_to_date('{Data[3]}','%d-%m-%Y'), '{hargaint}', '{promodoubleval.ToString().Replace(',','.')}','{Data[0]}','{Data[1]}', '{Data[6]}','F');";
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myreader = mycommand.ExecuteReader();
            myconnection.Close();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void Testnamainput()
        {
            hargaint = Convert.ToInt32(Data[4]);
            promoint = Convert.ToInt32(promo);
            total = (hargaint * (100 - promoint) )/ 100;
            promodoubleval = Convert.ToDouble(100.00 - promoint)/ 100.00;

            lbl_total.Text = total.ToString();
            label_receiptnamaservice.Text = Data[2];
            label_receipttanggal.Text = Data[3];
            label_receiptharga.Text = Data[4];
            lbl_promo.Text = promo + "%";
        }
    }
}



/*
string mysqlquary;
        string mysqlconnection = "server=localhost;uid=root;database=db_sad";
        int saveslot;
        MySqlConnection myconnection;
        MySqlCommand mycommand;
        MySqlDataAdapter myadapter;
        MySqlDataReader myreader;
        DataTable dt = new DataTable();

myconnection.Open();
            mysqlquary = $"insert into Penjualan (tgl_penjualan,harga_penjualan,promo,merk_mobil,plat_mobil,service_id,status_del) values ( str_to_date('{Data[3]}','%d-%m-%Y'), '{hargaint}', '{promodoubleval}','{Data[0]}','{Data[1]}', '{Data[6]}','F');";
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myreader = mycommand.ExecuteReader();
            myconnection.Close();


mysqlquary = $"select promo_id, promo_discount from promo where status_del = 'F' and if(curdate()<promo_end and curdate()>promo_start  ,\"true\",\"false\") = \"true\" limit 1;";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            myadapter.Fill(dt);


 */
