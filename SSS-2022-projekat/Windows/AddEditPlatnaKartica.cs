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
    public partial class AddEditPlatnaKartica : Form
    {
        public void PlatnaKartica(string brojKartice, int iznos)
        {
            PlatnaKartica kartica = new PlatnaKartica();
            this.txtBrojKartice.Text = brojKartice;
            this.txtIznos.Text = iznos.ToString();
            originalBrojKartice = this.txtBrojKartice.Text;

        }


        public bool isUpdate = false;
        string originalBrojKartice;
        SqlConnection conn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public AddEditPlatnaKartica()
        {

            InitializeComponent();
            if (this.txtBrojKartice.Text != "")
            {
                isUpdate = true;

            }
        }
        private void AddEditPlatnaKartica_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = FitnesCentar.CONNECTION_STRING;
            command.Connection = conn;
            da.SelectCommand = command;
            conn.Open();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(txtBrojKartice.Text != "" && txtIznos.Text != "")
            {
                conn.ConnectionString = FitnesCentar.CONNECTION_STRING;
                command.Connection = conn;
                da.SelectCommand = command;
                conn.Open();
            
                command.CommandText = "INSERT INTO PlatnaKartica VALUES('" + txtBrojKartice.Text + "', '" + txtIznos.Text + "');";        

                command.ExecuteNonQuery();
                ShowPlatnaKarticaWindow w = new ShowPlatnaKarticaWindow();
                conn.Close();
                w.UpdateGrid();
                w.Show();

                this.Close();


            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtBrojKartice.Text != "" && txtIznos.Text != "")
            { 
                conn.ConnectionString = FitnesCentar.CONNECTION_STRING;
                command.Connection = conn;
                da.SelectCommand = command;
                conn.Open();

                command.CommandText = "update PlatnaKartica set BrojKartice='" + txtBrojKartice.Text + "', Iznos='" + txtIznos.Text + "'" +
                        "where BrojKartice= '" + txtBrojKartice.Text + "';";

                command.ExecuteNonQuery();
                ShowPlatnaKarticaWindow w = new ShowPlatnaKarticaWindow();
                conn.Close();
                w.UpdateGrid();
                w.Show();

                this.Close();

            }
               
        }


        private void btnOdustani_Click(object sender, EventArgs e)
        {
            conn.Close();
            ShowPlatnaKarticaWindow w = new ShowPlatnaKarticaWindow();
            w.Show();
            this.Close();
        }

        
    }
}
