using SSS_2022_projekat.Model;
using SSS_2022_projekat.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS_2022_projekat
{
    public partial class ShowAllTrenerWindow : Form
    {
        SqlConnection sql = new SqlConnection(FitnesCentar.CONNECTION_STRING);
        public ShowAllTrenerWindow()
        {
            InitializeComponent();
            sql.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Ime, Prezime, Email, Lozinka, AdresaId, Pol, BrojTelefona, OsnovniJezik, Aktivan, Zvanje, BrojKartice FROM Trener;", sql);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table.DefaultView;
            sql.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trener t = new Trener();
            AddEditTrener adminKreirajKlijenta = new AddEditTrener(t);
            adminKreirajKlijenta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trener t = FitnesCentar.Instance.ListaTrenera.Find(k => k.Email.Equals(textBox1.Text));
            AddEditTrener adminKreirajKlijenta = new AddEditTrener(t);
            adminKreirajKlijenta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Open();
                SqlCommand delete = new SqlCommand("DELETE FROM Trener  WHERE email = '" + textBox1.Text + "';");
                delete.Connection = sql;
                delete.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("You have successfully delete trainer!");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid email!");
            }
        }
    }
}
