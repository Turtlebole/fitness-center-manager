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
    public partial class ShowAllOcena : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        int selectedId;
        public ShowAllOcena()
        {
            InitializeComponent();
        }

        public void UpdateGrid()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
        private void ShowAllOcena_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = FitnesCentar.CONNECTION_STRING;
            command.Connection = conn;
            da.SelectCommand = command;
            conn.Open();

            command.CommandText = "SELECT * FROM ocena order BY id asc";
            da.Fill(dt);

            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            AddEditOcena w = new AddEditOcena();
            w.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();

                command.CommandText = "delete FROM ocena where id='" + selectedId + "';";
                command.ExecuteNonQuery();

                command.CommandText = "SELECT * FROM ocena order BY id ASC";
                command.ExecuteNonQuery();
                dt.Clear();
                da.Fill(dt);
                UpdateGrid();

                conn.Close();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Sql greska");
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Greska");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedId = (int)row.Cells[0].Value;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
