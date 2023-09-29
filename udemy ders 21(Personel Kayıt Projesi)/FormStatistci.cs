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

namespace udemy_ders_21_Personel_Kayıt_Projesi_
{
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
        }
        SqlConnection baglanti2 = new SqlConnection("Data Source = LAPTOP-E82TE7I7\\SQLEXPRESS; Initial Catalog = PersonelVeriTabani; Integrated Security = True");
        private void FormStatistic_Load(object sender, EventArgs e)
        {
            baglanti2.Open();
            SqlCommand cmd1 = new SqlCommand("Select count(*) From Table_Personnel",baglanti2);
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                lblTopPer.Text = reader[0].ToString();
                /*Buradaki sifirinci index, count bir sayi buldugu icin ayni zamanda tek sutunlu bir sonuc 
                buldugu icin sifirinci indexi aliyoruz.*/
            }
            baglanti2.Close();

            baglanti2.Open();
            SqlCommand cmd2 = new SqlCommand("Select count(*) From Table_Personnel where PerSituation = 1", baglanti2);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                lblEvliPer.Text = reader2[0].ToString();
            }
            baglanti2.Close();

            baglanti2.Open();
            SqlCommand cmd3 = new SqlCommand("Select count(*) From Table_Personnel where PerSituation != 1", baglanti2);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while(reader3.Read())
            {
                lblBekPer.Text = reader3[0].ToString();
            }
            baglanti2.Close();

            baglanti2.Open();
            SqlCommand cmd4 = new SqlCommand("Select count(distinct(PerCity)) From Table_Personnel",baglanti2);
            SqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                lblSehirSayi.Text = reader4[0].ToString();
            }
            baglanti2.Close();

            baglanti2.Open();
            SqlCommand cmd5 = new SqlCommand("Select sum(PerSalary) From Table_Personnel", baglanti2);
            SqlDataReader reader5 = cmd5.ExecuteReader();
            while (reader5.Read())
            {
                lblTopMaas.Text = reader5[0].ToString();
            }
            baglanti2.Close();

            baglanti2.Open();
            SqlCommand cmd6 = new SqlCommand("Select avg(PerSalary) From table_personnel", baglanti2);
            SqlDataReader reader6 = cmd6.ExecuteReader();
            while( reader6.Read())
            {
                lblOrtMaas.Text = reader6[0].ToString();
            }

        }
    }
}
