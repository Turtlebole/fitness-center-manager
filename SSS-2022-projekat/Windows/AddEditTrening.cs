using SSS_2022_projekat.Model;
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

namespace SSS_2022_projekat.Windows
{
    public partial class AddEditTrening : Form
    {

        SqlConnection conn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable pripada = new DataTable();
        DataTable pripada1 = new DataTable();
        SqlConnection sql = new SqlConnection(FitnesCentar.CONNECTION_STRING);
        public Osoba osoba;

        public AddEditTrening(Osoba o)
        {
            osoba = o;

            sql.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id, TrenerEmail, KlijentEmail, DatumOdrzavanja, VremePocetka, Trajanje, Status, Cena, PlanTreninga  FROM Trening ");
            cmd.Connection = sql;
            SqlDataReader userInfo = cmd.ExecuteReader();
            InitializeComponent();
            sql.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Klijent k;

            if (comboBoxClient.Text == "")
            {
                k = new Klijent();
            }
            else
            {
                k = FitnesCentar.Instance.ListaKlijenata.Find(k => k.Email == comboBoxClient.Text);
            }
            Trening trening = new Trening
            {
                Trener = FitnesCentar.Instance.ListaTrenera.Find(t => t.Email == comboBoxCoach.Text),
                Klijent = k,
                DatumOdrzavanja = dateTimePickerDate.Value,
                VremePocetka = textBoxTime.Text,
                Trajanje = Int32.Parse(textBoxDuration.Text),
                Status = (EStatus)Enum.Parse(typeof(EStatus), comboBoxStatus.Text),
                Cena = Int32.Parse(textBoxPrice.Text),
                PlanTreninga = comboBox4.Text

            };

            FitnesCentar.Instance.SacuvajTrening(trening);
            FitnesCentar.Instance.ListaTreninga.Add(trening);

            ShowAllTreningWindow w = new ShowAllTreningWindow(osoba);
            w.UpdateGrid();
            w.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand update = new SqlCommand("UPDATE Trening SET TrenerEmail = ' " + comboBoxCoach.Text + "', KlijentEmail = '" + comboBoxClient.Text + "', DatumOdrzavanja = '" + DateTime.Parse(dateTimePickerDate.Text) +
                "', VremePocetka = '" + textBoxTime.Text + "', Trajanje = '" + int.Parse(textBoxDuration.Text) + "', Status = '" + comboBoxStatus.Text +
                "', Cena = '" + float.Parse(textBoxPrice.Text) + "', PlanTreninga = '" + comboBox4.Text + "';");
            update.Connection = sql;
            update.ExecuteNonQuery();
            ShowAllTreningWindow showAllTreningWindow = new ShowAllTreningWindow(osoba);
            sql.Close();
            showAllTreningWindow.UpdateGrid();
            showAllTreningWindow.Show();
            MessageBox.Show("Uspesno ste izmenili podatke treninga!");
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditTrening_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = FitnesCentar.CONNECTION_STRING;
            command.Connection = conn;
            da.SelectCommand = command;
            conn.Open();
            command.CommandText = "SELECT email FROM Klijent ";
            da.Fill(pripada);
            comboBoxClient.DataSource = pripada;
            comboBoxClient.ValueMember = "email";

            command.CommandText = "SELECT  email FROM Trener ";
            da.Fill(pripada1);
            comboBoxCoach.DataSource = pripada1;
            comboBoxCoach.ValueMember = "email";


            conn.Close();
        }
    }
}
