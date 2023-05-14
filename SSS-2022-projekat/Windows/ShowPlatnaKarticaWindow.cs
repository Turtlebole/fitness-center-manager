using SSS_2022_projekat.Model;
using SSS_2022_projekat.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS_2022_projekat
{
    public partial class ShowPlatnaKarticaWindow : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string selectedBroj;
        int selectedIznos;
        public ShowPlatnaKarticaWindow()
        {
            InitializeComponent();
            
        }
        public void UpdateGrid()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void ShowPlatnaKarticaWindow_Load(object sender, EventArgs e)
        {

            conn.ConnectionString = FitnesCentar.CONNECTION_STRING;
            command.Connection = conn;
            da.SelectCommand = command;
            conn.Open();

            command.CommandText = "SELECT * FROM PlatnaKartica ORDER BY Iznos ASC";
            da.Fill(dt);

            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditPlatnaKartica w = new AddEditPlatnaKartica();
            w.button2.Visible = false;

                w.Show();
                this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AddEditPlatnaKartica w = new AddEditPlatnaKartica();
            w.button1.Visible = false;
            w.isUpdate = true;
            w.PlatnaKartica(selectedBroj, selectedIznos);
            w.Show();
            this.Close();

        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedBroj = row.Cells[0].Value.ToString();
                selectedIznos = Int32.Parse(row.Cells[1].Value.ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = FitnesCentar.CONNECTION_STRING;
            command.Connection = conn;
            da.SelectCommand = command;
            conn.Open();

            command.CommandText = "delete FROM PlatnaKartica where brojKartice='"+selectedBroj+"';";
            command.ExecuteNonQuery();
            command.CommandText = "SELECT * FROM PlatnaKartica ORDER BY Iznos ASC";
            dt.Clear();
            da.Fill(dt);
            UpdateGrid();
            
            conn.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
