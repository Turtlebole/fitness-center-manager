using SSS_2022_projekat.Model;
using SSS_2022_projekat.Windows;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SSS_2022_projekat
{
    public partial class Form1: Form
    {
        public Osoba osoba;

        public Form1(Osoba o)
        {
            osoba = o;
            InitializeComponent();

            label1.Text = osoba.Ime + " " + osoba.Prezime;
            label10.Text = osoba.Email;
           
            
        }

        
        private void circularProgressBar1_Click(object sender, EventArgs e)
        {
            StartTrening start = new StartTrening();
            start.Show();
        }

        

        private void showAllTrener_click(object sender, EventArgs e)
        {
            ShowAllTrenerWindow show = new ShowAllTrenerWindow();
            show.Show();
        }

        private void showAllKlijent_click(object sender, EventArgs e)
        {
            ShowAllKlijentWindow show = new ShowAllKlijentWindow(osoba);
            show.Show();
        }

        private void showAllAdresa_click(object sender, EventArgs e)
        {
            ShowAllAdresaWindow show = new ShowAllAdresaWindow();
            show.Show();
        }

        private void showAllTrening_click(object sender, EventArgs e)
        {
            ShowAllTreningWindow show = new ShowAllTreningWindow(osoba);
            if(osoba is Klijent)
            {
                show.button1.Visible = false;
                show.button2.Visible = false;
            }
            show.Show();
        }

        private void showAllPlatnaKartica_click(object sender, EventArgs e)
        {
            ShowPlatnaKarticaWindow show = new ShowPlatnaKarticaWindow();
            show.Show();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
          
            this.Close();
            Login login = new Login();
            login.Show();
            
         
            
        }

        private void editProfil_click(object sender, EventArgs e)
        {
            if(osoba is Klijent)
            {
                Klijent klijent = FitnesCentar.Instance.ListaKlijenata.Find(k => k.Email.Equals(osoba.Email));

                AddEditKlijent edit = new AddEditKlijent(klijent);
                edit.textBoxEmail.ReadOnly = true;
                //edit.comboBoxPaymentCard.Visible = false;
                edit.textBoxCardNumber.Visible = false;
                edit.labelPaymentCard.Visible = false;
                edit.buttonCreate.Visible = false;
                edit.ShowDialog();
                

            }else if(osoba is Trener)
            {
                Trener trener = FitnesCentar.Instance.ListaTrenera.Find(t => t.Email.Equals(osoba.Email));

                AddEditTrener edit = new AddEditTrener(trener);
                edit.textBoxEmail.ReadOnly = true;
                //edit.comboBoxPaymentCard.Visible = false;
                edit.label11.Visible = false;
                edit.label9.Visible = false;
                //edit.radioButtonFalse.Visible = false;
                //edit.radioButtonTrue.Visible = false;
                edit.textBoxCardNumber.Visible = false;
                edit.textBoxActive.Visible = false;
                edit.buttonCreate.Visible = false;
                edit.ShowDialog();

            }

            
        }

        private void make_appointment(object sender, EventArgs e)
        {
            MakeAnAppointment mk = new MakeAnAppointment(osoba);
            mk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAllOcena show = new ShowAllOcena();
            show.Show();

        }
    }
}