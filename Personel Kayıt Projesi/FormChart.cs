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
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = LAPTOP-E82TE7I7\\SQLEXPRESS; Initial Catalog = PersonelVeriTabani; Integrated Security = True");

        private void FormChart_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmdc1 = new SqlCommand("Select PerCity, count(*) From Table_Personnel group by PerCity", baglanti);
            SqlDataReader alperen = cmdc1.ExecuteReader();
            while (alperen.Read())
            {
                chart1.Series["Cities"].Points.AddXY(alperen[0], alperen[1]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand cmdc2 = new SqlCommand("Select PerOccupation, avg(PerSalary) From Table_Personnel group by PerOccupation", baglanti);
            SqlDataReader alperen2 = cmdc2.ExecuteReader();
            while (alperen2.Read())
            {
                chart2.Series["Occupation-Salary"].Points.AddXY(alperen2[0], alperen2[1]);
            }
            baglanti.Close();
        }
    }
}
