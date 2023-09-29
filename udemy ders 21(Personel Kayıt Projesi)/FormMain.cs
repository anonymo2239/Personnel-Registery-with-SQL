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
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.Reporting.WinForms;

namespace udemy_ders_21_Personel_Kayıt_Projesi_
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtOccupation.Clear();
            mskSalary.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            cmbboxCity.Text = "";          
            txtName.Focus();
            txtID.Clear();
        }
        

        SqlConnection baglanti = new SqlConnection("Data Source = LAPTOP-E82TE7I7\\SQLEXPRESS; Initial Catalog = PersonelVeriTabani; Integrated Security = True");

        void listele()
        {
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Table_Personnel ORDER BY PerID ASC", baglanti);
            SqlDataReader reader = cmd2.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();

            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            txtID.Focus();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listele();
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_Personnel(PerName, PerSurname, PerCity, PerOCcupation, PerSalary, PerSituation) values (@p1, @p2, @a3, @a4, @a5, @b6)", baglanti);
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtSurname.Text);
            cmd.Parameters.AddWithValue("@a3", cmbboxCity.Text);
            cmd.Parameters.AddWithValue("@a4", txtOccupation.Text);
            cmd.Parameters.AddWithValue("@a5", mskSalary.Text);
            cmd.Parameters.AddWithValue("@b6", label8.Text);
            cmd.ExecuteNonQuery();
            
            baglanti.Close();
            MessageBox.Show("Saved Succesfuly", "Info");
            listele();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "true";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "false";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmdDel = new SqlCommand("delete from Table_Personnel where PerID = @m1", baglanti);
            cmdDel.Parameters.AddWithValue("@m1", txtID.Text);
            cmdDel.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Registery deleted", "Info");
            listele();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            cmbboxCity.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            mskSalary.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            txtOccupation.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
            //perfect
            //   |
            //   |
            //   |
            //  \|/

            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT Persituation FROM Table_Personnel WHERE PerID = @p1", baglanti);
            sqlCommand.Parameters.AddWithValue("@p1", txtID.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                label8.Text = reader[0].ToString();
            }
            baglanti.Close();
            if(label8.Text == "True")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else if(label8.Text == "False")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }

        private void btnUptade_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmdUpt = new SqlCommand("Update Table_Personnel set PerName = @alp1, PerSurname = @alp2, PerCity = @alp3, PerSalary = @alp4, PerSituation = @alp5, PerOccupation = @alp6 where PerID = @alp7", baglanti);
            cmdUpt.Parameters.Add("@alp1", txtName.Text);
            cmdUpt.Parameters.Add("@alp2", txtSurname.Text);
            cmdUpt.Parameters.Add("@alp3", cmbboxCity.Text);
            cmdUpt.Parameters.Add("@alp4", mskSalary.Text);
            cmdUpt.Parameters.Add("@alp5", label8.Text);
            cmdUpt.Parameters.Add("@alp6", txtOccupation.Text);
            cmdUpt.Parameters.Add("@alp7", txtID.Text);
            cmdUpt.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Uptaded succesfully");
            listele();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FormStatistic formStatistic = new FormStatistic();
            formStatistic.Show();
        }

        private void btnGraphics_Click(object sender, EventArgs e)
        {
            FormChart finalChart = new FormChart();
            finalChart.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Project developed by Alperen Arda", "Info");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReports formReports = new FormReports();
            formReports.Show();           
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Program being terminated...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}