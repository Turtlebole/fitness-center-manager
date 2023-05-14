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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            label17.Visible = false;
            panel9.Visible = false;
            textBoxProfession.Visible = false;
            buttonCertificate.Visible = false;

        }

        

        private void login_click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            
            
        }

        SqlConnection sql = new SqlConnection(FitnesCentar.CONNECTION_STRING);
       
        private void register_click(object sender, EventArgs e)
        {
                          
            if (comboBoxRole.Text == "KLIJENT" && FitnesCentar.Instance.ListaKlijenata.Find(k => k.Email.Equals(textBoxEmail.Text)) == null && FitnesCentar.Instance.ListaTrenera.Find(t => t.Email.Equals(textBoxEmail.Text)) == null && FitnesCentar.Instance.ListaAdmina.Find(a => a.Email.Equals(textBoxEmail.Text)) == null)
            {
                sql.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into Adresa values ('" + textBoxCountry.Text + "','" + textBoxCity.Text + "', '" + textBoxStreet.Text + "', '" + textBoxNumber.Text + "')", sql);
                sqlCommand.ExecuteNonQuery();
                SqlCommand sqlCommand3 = new SqlCommand("insert into PlatnaKartica values ('" + textBoxPlatnaKartica.Text + "','" + "" + "')", sql);
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
                SqlCommand sqlCommand2 = new SqlCommand("insert into Klijent values ('" + textBoxName.Text + "','" + textBoxLastName.Text + "', '" + textBoxEmail.Text + "', '" + textBoxPassword.Text + "','" + idReader.GetValue(0) + "','" + comboBoxGender.Text + "','" + textBoxPhoneNumber.Text + "','" + comboBoxPrimaryLanguage.Text + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + textBoxPlatnaKartica.Text + "')", sql);
                idReader.Close();
                sqlCommand2.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Registracija korisnika EMAIL: " + textBoxEmail.Text + " uspesna!");
                this.Close();

                FitnesCentar.Instance.UcitajKlijenta();

                Login login = new Login();
                login.Show();
            }

            else if (comboBoxRole.Text == "TRENER" && FitnesCentar.Instance.ListaTrenera.Find(t => t.Email.Equals(textBoxEmail.Text)) == null && FitnesCentar.Instance.ListaKlijenata.Find(k => k.Email.Equals(textBoxEmail.Text)) == null && FitnesCentar.Instance.ListaAdmina.Find(a => a.Email.Equals(textBoxEmail.Text)) == null)
            {

                sql.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into Adresa values ('" + textBoxCountry.Text + "','" + textBoxCity.Text + "', '" + textBoxStreet.Text + "', '" + textBoxNumber.Text + "')", sql);
                sqlCommand.ExecuteNonQuery();
                SqlCommand sqlCommand3 = new SqlCommand("insert into PlatnaKartica values ('" + textBoxPlatnaKartica.Text + "','" + "" + "')", sql);
                for (int i = 0; i < checkedListBoxJezici.Items.Count; i++)
                {
                    if (checkedListBoxJezici.GetItemChecked(i) == true)
                    {
                        SqlCommand sqlCommand5 = new SqlCommand("insert into DodatniJezici values ('" + textBoxEmail.Text + "','" + checkedListBoxJezici.Items[i].ToString() + "')", sql);
                        sqlCommand5.ExecuteNonQuery();
                    }

                }
                sqlCommand3.ExecuteNonQuery();
                SqlCommand sqlCommand4 = new SqlCommand("insert into DodatniJezici values ('" + textBoxEmail.Text + "','" + checkedListBoxJezici.Text + "')", sql);
                sqlCommand4.ExecuteNonQuery();
                SqlCommand adressId = new SqlCommand("SELECT max(Id) FROM Adresa");
                adressId.Connection = sql;
                SqlDataReader idReader = adressId.ExecuteReader();
                idReader.Read();
                SqlCommand sqlCommand2 = new SqlCommand("insert into Trener values ('" + textBoxName.Text + "','" + textBoxLastName.Text + "', '" + textBoxEmail.Text + "', '" + textBoxPassword.Text + "','" + idReader.GetValue(0) + "','" + comboBoxGender.Text + "','" + textBoxPhoneNumber.Text + "','" + comboBoxPrimaryLanguage.Text + "','" + 0 + "','" + textBoxProfession.Text +"','"  + textBoxPlatnaKartica.Text + "')", sql);
                idReader.Close();
                sqlCommand2.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("EMAIL: " + textBoxEmail.Text , "Registration successful!");
                this.Close();

                FitnesCentar.Instance.UcitajTrenera();

                Login login = new Login();
                login.Show();

            }

            else
            {
                MessageBox.Show("User already exists!", "Error");
            }
        }

        private void click_upload(object sender, EventArgs e)
        {               
            var source = new OpenFileDialog();
            if (source.ShowDialog() == DialogResult.OK)
            {               
                 File.Copy(source.FileName, @"...\..\..\..\..\Resources\" + Path.GetFileName(source.FileName));               
            }
            
        }

        private void role_change(object sender, EventArgs e)
        {
            if((sender as ComboBox).SelectedItem == "TRENER") 
            {
                label17.Visible = true;
                panel9.Visible = true;
                textBoxProfession.Visible = true;
                buttonCertificate.Visible = true;
            }
            else
            {
                label17.Visible = false;
                panel9.Visible = false;
                textBoxProfession.Visible = false;
                buttonCertificate.Visible = false;
            }
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
