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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            txtEmail.Text = "dragan@gmail.com";
            txtPassword.Text = "123";
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Boolean prijavljen = false;
            

            foreach(Admin a in FitnesCentar.Instance.ListaAdmina)
            {
                if(a.Email == txtEmail.Text && a.Lozinka == txtPassword.Text)
                {
                    this.Hide();
                    Form1 profil = new Form1(a);
                    profil.Show();
                    
  
                    profil.Text = "Admin";


                    profil.button3.Hide();
                    prijavljen = true;

                    profil.labelBrojAdmina.Text = FitnesCentar.Instance.ListaAdmina.Count().ToString();
                    profil.labelBrojKlijenata.Text = FitnesCentar.Instance.ListaKlijenata.Count().ToString();
                    profil.labelBrojTrenera.Text = FitnesCentar.Instance.ListaTrenera.Count().ToString();

                } 
            }

            foreach (Klijent k in FitnesCentar.Instance.ListaKlijenata)
            {
                if (k.Email == txtEmail.Text && k.Lozinka == txtPassword.Text)
                {
                    this.Hide();
                    Form1 profil = new Form1(k);
                    profil.Show(); 
                    

                    profil.Text = "Klijent";

                    profil.button5.Hide();
                    profil.button6.Hide();
                    profil.button7.Hide();
                    profil.button8.Hide();
                    profil.button1.Hide();
                    profil.panel3.Hide();
                    prijavljen = true;

                }
            }
            foreach (Trener t in FitnesCentar.Instance.ListaTrenera)
            {
                if (t.Email == txtEmail.Text && t.Lozinka == txtPassword.Text && t.Aktivan == true)
                {
                    this.Hide();
                    Form1 profil = new Form1(t);                
                    profil.Show();
                    

                    profil.Text = "Trener";

                    profil.button3.Hide();
                    profil.button6.Hide();
                    profil.button7.Hide();
                    profil.button5.Hide();
                    profil.button1.Hide();
                    profil.panel3.Hide();
                    prijavljen = true;

                }
            }

            if(prijavljen == false)
            {
                MessageBox.Show("User don't exist or account is not activated", "Error!");
            }

        }
    

        private void signUp_click(object sender, EventArgs e)
        {   
            this.Hide();      
            Register register = new Register();      
            register.Show();
            
        }
    }
}


