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
    public partial class AddEditOcena : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable pripada = new DataTable();
        public AddEditOcena()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEditOcena_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = FitnesCentar.CONNECTION_STRING;
            command.Connection = conn;
            da.SelectCommand = command;
            conn.Open();
            command.CommandText = "SELECT ime, prezime, email FROM Klijent " +
                "UNION ALL " +
                "SELECT ime, prezime, email FROM Trener";



            da.Fill(pripada);
            pripada.Columns.Add(
                "FullName", typeof(string), "ime+' '+prezime");
            cmbPripada.DataSource = pripada;
            cmbPripada.DisplayMember = "FullName";
            cmbPripada.ValueMember = "email";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            conn.Close();
            conn.Open();


            command.CommandText = "INSERT INTO Ocena VALUES('"
            + cmbPripada.SelectedValue + "', '" + txtOcena.Text +
            "', '" + txtKomentar.Text + "');";
            command.ExecuteNonQuery();
            conn.Close();
            ShowAllOcena w = new ShowAllOcena();
            w.UpdateGrid();
            w.Show();
            this.Close();

        }
    }
}
