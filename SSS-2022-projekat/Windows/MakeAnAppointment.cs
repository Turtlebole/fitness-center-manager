using SSS_2022_projekat.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS_2022_projekat.Windows
{
    public partial class MakeAnAppointment : Form
    {
        public Osoba osoba;

        public MakeAnAppointment(Osoba o)
        {
            InitializeComponent();
            osoba = o;

            comboBoxTrener.DataSource = FitnesCentar.Instance.ListaTrenera;


        }

        private void trener_change(object sender, EventArgs e)
        {
            Trener t = (Trener)comboBoxTrener.SelectedItem;
            comboBoxTermin.DataSource = t.SviTreninzi.FindAll(tr => tr.Status.Equals(EStatus.SLOBODAN));
        }

        private void btnMakeAppointment(object sender, EventArgs e)
        {
            Trener t = (Trener)comboBoxTrener.SelectedItem;
            Trening trening = (Trening)comboBoxTermin.SelectedItem;

            (osoba as Klijent).rezervisiTrening(trening);
            t.SviKlijenti.Add(osoba as Klijent);
            FitnesCentar.Instance.IzmeniTrening(trening);


            ShowAllTreningWindow w = new ShowAllTreningWindow(osoba);
            w.button1.Visible = false;
            w.button2.Visible = false;
            w.UpdateGrid();
            w.Show();

            this.Close();

        }
    }
}
