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
    public partial class ShowAllKlijentWindow : Form
    {
        public Osoba osoba;
        SqlConnection sql = new SqlConnection(FitnesCentar.CONNECTION_STRING);
        public ShowAllKlijentWindow(Osoba o)
        {
            InitializeComponent();
            /*sql.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Ime, Prezime, Email, Lozinka, AdresaId, Pol, BrojTelefona, OsnovniJezik, Visina, Tezina, StanjaIBolesti, ObimKukova, ObimStruka, ObimGrudi, BrojKartice FROM Klijent;", sql);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table.DefaultView;
            sql.Close();*/

            osoba = o;

            if (osoba is Trener)
            {
                dataGridView1.DataSource = (osoba as Trener).SviKlijenti.Distinct().ToList();
                dataGridView1.ReadOnly = true;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                textBox1.Visible = false;

                /*sql.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Ime, Prezime, Email, Lozinka, AdresaId, Pol, BrojTelefona, OsnovniJezik, Visina, Tezina, StanjaIBolesti, ObimKukova, ObimStruka, ObimGrudi, BrojKartice FROM Klijent k Where k.Email;", sql);
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                dataGridView1.DataSource = table.DefaultView;
                sql.Close();*/


            }
            else if (osoba is Admin)
            {
                dataGridView1.DataSource = FitnesCentar.Instance.ListaKlijenata;
                sql.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Ime, Prezime, Email, Lozinka, AdresaId, Pol, BrojTelefona, OsnovniJezik, Visina, Tezina, StanjaIBolesti, ObimKukova, ObimStruka, ObimGrudi, BrojKartice FROM Klijent;", sql);
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                dataGridView1.DataSource = table.DefaultView;
                sql.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Klijent k = new Klijent();
            AddEditKlijent adminKreirajKlijenta = new AddEditKlijent(k);
            adminKreirajKlijenta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Klijent k = FitnesCentar.Instance.ListaKlijenata.Find(k => k.Email.Equals(textBox1.Text));
            AddEditKlijent adminKreirajKlijenta = new AddEditKlijent(k);
            adminKreirajKlijenta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Open();
                SqlCommand delete = new SqlCommand("DELETE FROM Klijent  WHERE email = '" + textBox1.Text + "';");
                delete.Connection = sql;
                delete.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("You have successfully delete client!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid email!");
            }
        }
    }
}
