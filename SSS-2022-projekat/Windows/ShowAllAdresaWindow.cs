using SSS_2022_projekat.Model;
using SSS_2022_projekat.Windows;
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

namespace SSS_2022_projekat
{
    public partial class ShowAllAdresaWindow : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string selectedId;
        public ShowAllAdresaWindow()
        {
            InitializeComponent();
        }
        public void UpdateGrid()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
        private void ShowAllAdresaWindow_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = FitnesCentar.CONNECTION_STRING;
            command.Connection = conn;
            da.SelectCommand = command;
            conn.Open();

            command.CommandText = "SELECT * FROM Adresa order BY id ASC";
            da.Fill(dt);

            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditAdresa w = new AddEditAdresa(selectedId);
            w.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*AddEditPlatnaKartica w = new AddEditPlatnaKartica();

            w.isUpdate = true;
            //w.PlatnaKartica(selectedBroj, selectedIznos);
            w.Show();
            this.Close();*/
            conn.Close();
            if (selectedId != null)
            {
                AddEditAdresa w = new AddEditAdresa(selectedId);

                w.isUpdate = true;
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedId = row.Cells[0].Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*conn.ConnectionString = FitnesCentar.CONNECTION_STRING;
            command.Connection = conn;
            da.SelectCommand = command;
            conn.Open();

            command.CommandText = "delete FROM Adresa where id='" + selectedId + "';";
            command.ExecuteNonQuery();

            command.CommandText = "SELECT * FROM Adresa order BY id ASC";
            dt.Clear();
            da.Fill(dt);
            UpdateGrid();

            conn.Close();*/
            try
            {
                conn.Open();

                command.CommandText = "delete FROM Adresa where id='" + selectedId + "';";
                command.ExecuteNonQuery();

                command.CommandText = "SELECT * FROM Adresa order BY id ASC";
                dt.Clear();
                da.Fill(dt);
                UpdateGrid();

                conn.Close();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Izabrana Adresa ne moze da se obrise jer se koristi");
                conn.Close();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
