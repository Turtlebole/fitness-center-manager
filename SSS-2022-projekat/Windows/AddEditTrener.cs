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
    public partial class AddEditTrener : Form
    {
        SqlConnection sql = new SqlConnection(FitnesCentar.CONNECTION_STRING);
        public Trener trener;

        public AddEditTrener(Trener t)
        {
            trener = t;
            sql.Open();
            SqlCommand cmd = new SqlCommand("SELECT Ime, Prezime, Email, Lozinka, AdresaId, Pol, BrojTelefona, OsnovniJezik, Aktivan, Zvanje, BrojKartice from Trener where Email = '" + trener.Email + "'");
            cmd.Connection = sql;
            SqlDataReader userInfo = cmd.ExecuteReader();
            InitializeComponent();

            this.Text = "Edit " + "" + "[ " + trener.Email + " ]";
            //comboBoxPaymentCard.DataSource = FitnesCentar.Instance.ListaPlatnihKartica;
            textBoxName.Text = trener.Ime;
            textBoxLastName.Text = trener.Prezime;
            textBoxEmail.Text = trener.Email;
            textBoxPassword.Text = trener.Lozinka;
            textBoxPhoneNumber.Text = trener.BrojTelefona;
            textBoxCountry.Text = trener.Adresa.Drzava;
            textBoxStreet.Text = trener.Adresa.Ulica;
            textBoxCity.Text = trener.Adresa.Grad;
            textBoxNumber.Text = trener.Adresa.Broj.ToString();
            comboBoxGender.SelectedItem = trener.Pol.ToString();
            comboBoxPrimaryLanguage.SelectedItem = trener.OsnovniJezik;
            textBoxActive.Text = trener.Aktivan.ToString();
            textBoxProfession.Text = trener.Zvanje.ToString();
            while (userInfo.Read())
            {
                textBoxCardNumber.Text = userInfo.GetValue(10).ToString();

            }
            userInfo.Close();
            sql.Close();


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void AddEditTrener_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void create_click(object sender, EventArgs e)
        {

            sql.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into Adresa values ('" + textBoxCountry.Text + "','" + textBoxCity.Text + "', '" + textBoxStreet.Text + "', '" + textBoxNumber.Text + "')", sql);
            sqlCommand.ExecuteNonQuery();
            SqlCommand sqlCommand3 = new SqlCommand("insert into PlatnaKartica values ('" + textBoxCardNumber.Text + "','" + "" + "')", sql);
            sqlCommand3.ExecuteNonQuery();
            for (int i = 0; i < checkedListBoxJezici.Items.Count; i++)
            {
                if (checkedListBoxJezici.GetItemChecked(i) == true)
                {
                    SqlCommand sqlCommand4 = new SqlCommand("insert into DodatniJezici values ('" + textBoxEmail.Text + "','" + checkedListBoxJezici.Items[i].ToString() + "')", sql);
                    sqlCommand4.ExecuteNonQuery();

                }

            }

            SqlCommand adressId = new SqlCommand("SELECT max(Id) FROM Adresa");
            adressId.Connection = sql;
            SqlDataReader idReader = adressId.ExecuteReader();
            idReader.Read();
            SqlCommand sqlCommand2 = new SqlCommand("insert into Trener values ('" + textBoxName.Text + "','" + textBoxLastName.Text + "', '" + textBoxEmail.Text + "', '" + textBoxPassword.Text + "','" + idReader.GetValue(0) + "','" + comboBoxGender.Text + "','" + textBoxPhoneNumber.Text + "','" + comboBoxPrimaryLanguage.Text + "','" + textBoxActive.Text + "','" + textBoxProfession.Text + "','" + textBoxCardNumber.Text + "')", sql);
            idReader.Close();
            sqlCommand2.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Kreiranje trenera EMAIL: " + textBoxEmail.Text + " uspesno!");
            this.Close();
        }

        private void update_click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand update = new SqlCommand("UPDATE Trener SET Ime = ' " + textBoxName.Text + "', Prezime = '" + textBoxLastName.Text + "', Email = '" + textBoxEmail.Text +
                "', Lozinka = '" + textBoxPassword.Text + "', BrojTelefona = '" + textBoxPhoneNumber.Text + "', Aktivan = '" + textBoxActive.Text +
                "', Zvanje = '" + textBoxProfession.Text + "', BrojKartice = '" + textBoxCardNumber.Text + "' WHERE Email = '" + trener.Email + "';");
            update.Connection = sql;
            update.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Uspesno ste izmenili podatke trenera!");
            this.Close();
        }
    }
}
