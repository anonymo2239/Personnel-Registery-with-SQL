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
    public partial class FormEntry : Form
    {
        public FormEntry()
        {
            InitializeComponent();
        }

        SqlConnection baglanti3 = new SqlConnection("Data Source=LAPTOP-E82TE7I7\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void btnenter_Click(object sender, EventArgs e)
        {
            baglanti3.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * From Table_Manager where UserName = @p1 and Password = @p2", baglanti3);
            sqlCommand.Parameters.AddWithValue("@p1", txtUserName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtpw.Text);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                FormMain formMain = new FormMain();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password. Please try again.","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            baglanti3.Close();

        }
    }
}
