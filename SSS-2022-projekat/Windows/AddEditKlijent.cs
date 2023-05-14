using SSS_2022_projekat.Model;
using System;
using System.Collections;
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
    public partial class AddEditKlijent : Form
    {
        SqlConnection sql = new SqlConnection(FitnesCentar.CONNECTION_STRING);
        public Klijent klijent;
       

        public AddEditKlijent(Klijent k)
        {
            klijent = k;

            sql.Open();
            SqlCommand cmd = new SqlCommand("SELECT Ime, Prezime, Email, Lozinka, AdresaId, Pol, BrojTelefona, OsnovniJezik, Visina, Tezina, StanjaIBolesti, ObimKukova, ObimStruka, ObimGrudi, BrojKartice FROM Klijent where Email = '" + klijent.Email + "'");
            cmd.Connection = sql;
            SqlDataReader userInfo = cmd.ExecuteReader();
            InitializeComponent();

            

            this.Text = "Edit " + "" + "[ " + klijent.Email + " ]";
            //comboBoxPaymentCard.DataSource = FitnesCentar.Instance.ListaPlatnihKartica;

            textBoxName.Text = klijent.Ime;
            textBoxLastName.Text = klijent.Prezime;
            textBoxEmail.Text = klijent.Email;
            textBoxPassword.Text = klijent.Lozinka;
            textBoxPhoneNumber.Text = klijent.BrojTelefona;
            textBoxCountry.Text = klijent.Adresa.Drzava;
            textBoxStreet.Text = klijent.Adresa.Ulica;
            textBoxCity.Text = klijent.Adresa.Grad;
            textBoxNumber.Text = klijent.Adresa.Broj.ToString();
            comboBoxGender.SelectedItem = klijent.Pol.ToString();
            comboBoxPrimaryLanguage.SelectedItem = klijent.OsnovniJezik;
            textBoxHeight.Text = klijent.Visina.ToString();
            boxWeight.Value = (decimal)klijent.Visina;
            boxWaistSize.Value = (decimal)klijent.ObimStruka;
            boxHipSize.Value = (decimal)klijent.ObimKukova;
            boxChestSize.Value = (decimal)klijent.ObimGrudi;
            textBoxConditionsAndDiseases.Text = klijent.StanjaIBolesti;
            while (userInfo.Read())
            {
                textBoxCardNumber.Text = userInfo.GetValue(14).ToString();

            }
            userInfo.Close();
            sql.Close();
        }

        private void create_click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into Adresa values ('" + textBoxCountry.Text + "','" + textBoxCity.Text + "', '" + textBoxStreet.Text + "', '" + textBoxNumber.Text + "')", sql);
            sqlCommand.ExecuteNonQuery();
            SqlCommand sqlCommand3 = new SqlCommand("insert into PlatnaKartica values ('" + textBoxCardNumber.Text + "','" + "" + "')", sql);
            sqlCommand3.ExecuteNonQuery();
            for (int i = 0; i < checkedListBoxOtherLanguages.Items.Count; i++)
            {
                if (checkedListBoxOtherLanguages.GetItemChecked(i) == true)
                {
                    SqlCommand sqlCommand4 = new SqlCommand("insert into DodatniJezici values ('" + textBoxEmail.Text + "','" + checkedListBoxOtherLanguages.Items[i].ToString() + "')", sql);
                    sqlCommand4.ExecuteNonQuery();

                }

            }
            for (int i = 0; i < checkedListBoxProps.Items.Count; i++)
            {
                if (checkedListBoxProps.GetItemChecked(i) == true)
                {
                    SqlCommand sqlCommand5 = new SqlCommand("insert into Rekviziti values ('" + textBoxEmail.Text + "','" + checkedListBoxProps.Items[i].ToString() + "')", sql);
                    sqlCommand5.ExecuteNonQuery();

                }

            }
            for (int i = 0; i < checkedListBoxGoals.Items.Count; i++)
            {
                if (checkedListBoxGoals.GetItemChecked(i) == true)
                {
                    SqlCommand sqlCommand6 = new SqlCommand("insert into Ciljevi values ('" + textBoxEmail.Text + "','" + checkedListBoxGoals.Items[i].ToString() + "')", sql);
                    sqlCommand6.ExecuteNonQuery();

                }

            }

            SqlCommand adressId = new SqlCommand("SELECT max(Id) FROM Adresa");
            adressId.Connection = sql;
            SqlDataReader idReader = adressId.ExecuteReader();
            idReader.Read();
            SqlCommand sqlCommand2 = new SqlCommand("insert into Klijent values ('" + textBoxName.Text + "','" + textBoxLastName.Text + "', '" + textBoxEmail.Text + "', '" + textBoxPassword.Text + "','" + idReader.GetValue(0) + "','" + comboBoxGender.Text + "','" + textBoxPhoneNumber.Text + "','" + comboBoxPrimaryLanguage.Text + "','" + textBoxHeight.Text + "','" + boxWeight.Text + "','" + textBoxConditionsAndDiseases.Text + "','" + boxHipSize.Text + "','" + boxWaistSize.Text + "','" + boxChestSize.Text + "','" + textBoxCardNumber.Text + "')", sql);
            idReader.Close();
            sqlCommand2.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Kreiranje korisnika EMAIL: " + textBoxEmail.Text + " uspesno!");
            this.Close();
        }

        private void update_click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand update = new SqlCommand("UPDATE Klijent SET Ime = ' " + textBoxName.Text + "', Prezime = '" + textBoxLastName.Text + "', Email = '" + textBoxEmail.Text +
                "', Lozinka = '" + textBoxPassword.Text + "', BrojTelefona = '" + textBoxPhoneNumber.Text + "', Visina = '" + textBoxHeight.Text +
                "', Tezina = '" + decimal.Parse(boxWeight.Text) + "', StanjaIBolesti = '" + textBoxConditionsAndDiseases.Text + "', ObimKukova = '" + decimal.Parse(boxHipSize.Text) + "', ObimStruka = '" + decimal.Parse(boxWaistSize.Text) + "', ObimGrudi = '" + decimal.Parse(boxChestSize.Text) + "', BrojKartice = '" + textBoxCardNumber.Text + "' WHERE Email = '" + klijent.Email + "';");
            update.Connection = sql;
            update.ExecuteNonQuery();
            for (int i = 0; i < checkedListBoxProps.Items.Count; i++)
            {
                if (checkedListBoxProps.GetItemChecked(i) == true)
                {
                    SqlCommand sqlCommand5 = new SqlCommand("insert into Rekviziti values ('" + textBoxEmail.Text + "','" + checkedListBoxProps.Items[i].ToString() + "')", sql);
                    sqlCommand5.ExecuteNonQuery();

                }

            }
            for (int i = 0; i < checkedListBoxGoals.Items.Count; i++)
            {
                if (checkedListBoxGoals.GetItemChecked(i) == true)
                {
                    SqlCommand sqlCommand6 = new SqlCommand("insert into Ciljevi values ('" + textBoxEmail.Text + "','" + checkedListBoxGoals.Items[i].ToString() + "')", sql);
                    sqlCommand6.ExecuteNonQuery();

                }

            }
            sql.Close();
            MessageBox.Show("Uspesno ste izmenili podatke klijenta!");
            this.Close();


        }

        private void back_click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
