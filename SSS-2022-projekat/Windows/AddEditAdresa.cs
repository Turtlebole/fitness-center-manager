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
    public partial class AddEditAdresa : Form
    {
        public bool isUpdate = false;

        SqlConnection conn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string selectedId;
        public AddEditAdresa(string id)
        {
            InitializeComponent();
            conn.Close();
            conn.ConnectionString = FitnesCentar.CONNECTION_STRING;
            command.Connection = conn;
            da.SelectCommand = command;
            conn.Open();

            selectedId = id;
            isUpdate = true;
            command.CommandText = "select * from adresa where id='" + id + "'";
            command.ExecuteNonQuery();
            dt.Clear();
            da.Fill(dt);

            DataRow row = dt.Rows[0];
            txtBroj.Text = row["broj"].ToString();
            txtDrzava.Text = row["drzava"].ToString();
            txtGrad.Text = row["grad"].ToString();
            txtUlica.Text = row["ulica"].ToString();

            this.Show();
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txtBroj.Text != "" && txtDrzava.Text != ""
                && txtGrad.Text != "" && txtUlica.Text != "")
                if (isUpdate == false)
                    command.CommandText = "INSERT INTO Adresa VALUES('"
                        + txtDrzava.Text + "', '" + txtGrad.Text +
                        "', '" + txtUlica.Text + "', '" + txtBroj.Text + "');";
                else
                    command.CommandText = "update Adresa set Drzava='" + txtDrzava.Text + "', Grad='" + txtGrad.Text +
                        "', Ulica='" + txtUlica.Text + "', Broj='" + txtBroj.Text + "'" +
                        "where Id= '" + selectedId + "';";

            command.ExecuteNonQuery();
            ShowAllAdresaWindow w = new ShowAllAdresaWindow();
            conn.Close();
            w.UpdateGrid();
            w.Show();

            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowAllAdresaWindow w = new ShowAllAdresaWindow();
            conn.Close();
            w.Show();
            this.Close();
        }
    }
}
