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
    public partial class ShowAllTreningWindow : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlConnection sql = new SqlConnection(FitnesCentar.CONNECTION_STRING);
        public Osoba osoba;
        public int id;

        public ShowAllTreningWindow(Osoba o)
        {
            InitializeComponent();
            osoba = o;

            if (osoba is Klijent)
            {
                dataGridView1.DataSource = (osoba as Klijent).ZakazaniTreninzi;
                dataGridView1.ReadOnly = true;

            }
            else if (osoba is Trener)
            {
                dataGridView1.DataSource = (osoba as Trener).SviTreninzi;

            }
            else if (osoba is Admin)
            {
                dataGridView1.DataSource = FitnesCentar.Instance.ListaTreninga;

            }

        }

        public void UpdateGrid()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void btnCreate(object sender, EventArgs e)
        {
            AddEditTrening w = new AddEditTrening(osoba);
            w.button2.Visible = false;
            w.Show();
            this.Close();


        }

        private void btnUpdate(object sender, EventArgs e)
        {

            AddEditTrening w = new AddEditTrening(osoba);
            w.button1.Visible = false;
            w.Show();

        }

        private void btnDelete(object sender, EventArgs e)
        {
            /*conn.ConnectionString = FitnesCentar.CONNECTION_STRING;
            command.Connection = conn;
            da.SelectCommand = command;
            conn.Open();

            command.CommandText = "DELETE FROM Trening  WHERE Id = '" + textBox1.Text + "';";
            command.ExecuteNonQuery();
            command.CommandText = "SELECT * FROM Trening ";
            dt.Clear();
            da.Fill(dt);
            UpdateGrid();

            conn.Close();
            MessageBox.Show("Uspesno ste obrisali trening!");*/
            if (osoba is Klijent)
            {
                Trening trening = FitnesCentar.Instance.ListaTreninga.Find(t => t.ID.Equals(id));
                (osoba as Klijent).otkaziTrening(trening);
                FitnesCentar.Instance.IzmeniTrening(trening);

                ShowAllTreningWindow w = new ShowAllTreningWindow(osoba);
                w.button1.Visible = false;
                w.button2.Visible = false;
                w.UpdateGrid();
                w.Show();

                this.Close();
                MessageBox.Show("You have successfully canceled your appointment!");


            }
            else
            {
                Trening trening = FitnesCentar.Instance.ListaTreninga.Find(t => t.ID.Equals(id));

                if (trening.Status.Equals(EStatus.SLOBODAN))
                {
                    try
                    {
                        sql.Open();
                        SqlCommand delete = new SqlCommand("DELETE FROM Trening  WHERE Id = '" + id + "';");
                        delete.Connection = sql;
                        delete.ExecuteNonQuery();
                        sql.Close();

                        FitnesCentar.Instance.ListaTreninga.Remove(trening);

                        ShowAllTreningWindow w = new ShowAllTreningWindow(osoba);
                        w.UpdateGrid();
                        w.Show();

                        this.Close();
                        MessageBox.Show("You have successfully delete your appointment!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error!");
                    }


                }
                else
                {
                    MessageBox.Show("You can't delete your appointment!");
                }


            }


        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = Int32.Parse(row.Cells[0].Value.ToString());

            }
        }
    }
}
