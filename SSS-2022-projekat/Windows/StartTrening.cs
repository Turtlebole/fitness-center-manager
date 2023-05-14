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
    public partial class StartTrening : Form
    {
        public StartTrening()
        {
            InitializeComponent();
            
        }
        int Chrono = 100;
        int Count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Chrono -= 1;
            Count += 1;
            TimingBar.Value = Count;
            Timelbl.Text = "" + Chrono;
            if(TimingBar.Value == 100)
            {
                TimingBar.Value = 0;
                timer1.Stop();
                MessageBox.Show("Trainig is over");
                this.Hide();
                AddEditOcena ado = new AddEditOcena();
                ado.Show();
         

            }
        }

        private void StartTrening_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
