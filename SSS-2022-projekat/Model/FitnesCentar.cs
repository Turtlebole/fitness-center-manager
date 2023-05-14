using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace SSS_2022_projekat.Model
{
    internal class FitnesCentar
    {                                                                  //(localdb)\MSSQLLocalDB //msdb
        public static readonly string CONNECTION_STRING = @"Data Source=(localdb)\ProjectModels;Initial Catalog=model;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private static readonly FitnesCentar instance = new FitnesCentar();

        public static FitnesCentar Instance
        {
            get
            {
                return instance;
            }
        }

        public FitnesCentar()
        {
            this.zaradaAplikacije = 0;
            this.listaAdresa = new List<Adresa>();
            this.listaTrenera = new List<Trener>();
            this.listaKlijenata = new List<Klijent>();
            this.listaTreninga = new List<Trening>();
            this.listaOcena = new List<Ocena>();
            this.listaAdmina = new List<Admin>();
            this.listaPlatnihKartica = new List<PlatnaKartica>();
        }

        private float zaradaAplikacije;

        public float ZaradaAplikacije
        {
            get { return zaradaAplikacije; }
            set { zaradaAplikacije = value; }
        }

        private List<Adresa> listaAdresa;
        public List<Adresa> ListaAdresa
        {
            get { return listaAdresa; }
            set { listaAdresa = value; }
        }

        private List<Trener> listaTrenera;
        public List<Trener> ListaTrenera
        {
            get { return listaTrenera; }
            set { listaTrenera = value; }
        }

        private List<Klijent> listaKlijenata;
        public List<Klijent> ListaKlijenata
        {
            get { return listaKlijenata; }
            set { listaKlijenata = value; }
        }

        private List<Trening> listaTreninga;
        public List<Trening> ListaTreninga
        {
            get { return listaTreninga; }
            set { listaTreninga = value; }
        }
        private List<Ocena> listaOcena;
        public List<Ocena> ListaOcena
        {
            get { return listaOcena; }
            set { listaOcena= value; }
        }
        private List<Admin> listaAdmina;
        public List<Admin> ListaAdmina
        {
            get { return listaAdmina; }
            set { listaAdmina= value; }
        }

        private List<PlatnaKartica> listaPlatnihKartica;     
        public List<PlatnaKartica> ListaPlatnihKartica
        {
            get { return listaPlatnihKartica; }
            set { listaPlatnihKartica = value; }
        }


        //-------------------------------------------------------------------------------

        public void IzmeniAdmina(Admin admin)
        {

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"update dbo.Admin
                set Ime = @Ime,Prezime = @Prezime,Email = @Email,Lozinka = @Lozinka,
                    AdresaId = @AdresaId, Pol = @Pol,BrojTelefona = @BrojTelefona
                    where Email = @Email";


                Enum.TryParse("" + admin.Pol + "", out EPol pol);

                command.Parameters.Add(new SqlParameter("Ime", admin.Ime));
                command.Parameters.Add(new SqlParameter("Prezime", admin.Prezime));
                command.Parameters.Add(new SqlParameter("Email", admin.Email));
                command.Parameters.Add(new SqlParameter("Lozinka", admin.Lozinka));
                command.Parameters.Add(new SqlParameter("AdresaId", admin.Adresa.ID));
                command.Parameters.Add(new SqlParameter("Pol", pol.ToString()));
                command.Parameters.Add(new SqlParameter("BrojTelefona",admin.BrojTelefona));
                
                command.ExecuteScalar();
            }
        }

        public void IzmeniTrenera(Trener trener)
        {

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"update dbo.Trener
                set Ime = @Ime,Prezime = @Prezime,Email = @Email,Lozinka = @Lozinka,
                    AdresaId = @AdresaId, Pol = @Pol,BrojTelefona = @BrojTelefona,OsnovniJezik = @OsnovniJezik,Aktivan=@Aktivan,
                    Zvanje=@Zvanje,BrojKartice=@BrojKartice
                    where Email = @Email";

                Enum.TryParse("" + trener.Pol + "", out EPol pol);


                command.Parameters.Add(new SqlParameter("Ime", trener.Ime));
                command.Parameters.Add(new SqlParameter("Prezime", trener.Prezime));     
                command.Parameters.Add(new SqlParameter("Email", trener.Email));
                command.Parameters.Add(new SqlParameter("Lozinka", trener.Lozinka));
                command.Parameters.Add(new SqlParameter("AdresaId", trener.Adresa.ID));
                command.Parameters.Add(new SqlParameter("BrojTelefona", trener.BrojTelefona));
                command.Parameters.Add(new SqlParameter("Pol", pol.ToString()));
                command.Parameters.Add(new SqlParameter("OsnovniJezik", trener.OsnovniJezik));
                command.Parameters.Add(new SqlParameter("Aktivan", trener.Aktivan));
                command.Parameters.Add(new SqlParameter("Zvanje", trener.Zvanje));
                command.Parameters.Add(new SqlParameter("BrojKartice", trener.PlatnaKartica.BrojKartice));
                command.ExecuteScalar();
            }
        }

        public void IzmeniKlijenta(Klijent klijent)
        {

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"update dbo.Klijent
                set Ime = @Ime,Prezime = @Prezime,Email = @Email,Lozinka = @Lozinka,
                    Pol = @Pol,BrojTelefona = @BrojTelefona,OsnovniJezik = @OsnovniJezik,
                    Visina = @Visina,Tezina = @Tezina,StanjaIBolesti=@StanjaIBolesti,ObimKukova=@ObimKukova,
                    ObimStruka=@ObimStruka,ObimGrudi=@ObimGrudi,BrojKartice=@BrojKartice
                    where Email = @Email";


                Enum.TryParse("" + klijent.Pol + "", out EPol pol);

                command.Parameters.Add(new SqlParameter("Ime", klijent.Ime));
                command.Parameters.Add(new SqlParameter("Prezime", klijent.Prezime));
                command.Parameters.Add(new SqlParameter("Email", klijent.Email));
                command.Parameters.Add(new SqlParameter("Lozinka", klijent.Lozinka));            
                command.Parameters.Add(new SqlParameter("Pol", pol.ToString()));
                command.Parameters.Add(new SqlParameter("BrojTelefona", klijent.BrojTelefona));
                command.Parameters.Add(new SqlParameter("OsnovniJezik", klijent.OsnovniJezik));
                command.Parameters.Add(new SqlParameter("Visina", klijent.Visina));
                command.Parameters.Add(new SqlParameter("Tezina", klijent.Tezina));
                command.Parameters.Add(new SqlParameter("StanjaIBolesti", klijent.StanjaIBolesti));
                command.Parameters.Add(new SqlParameter("ObimKukova", klijent.ObimKukova));
                command.Parameters.Add(new SqlParameter("ObimStruka", klijent.ObimStruka));
                command.Parameters.Add(new SqlParameter("ObimGrudi", klijent.ObimGrudi));
                command.Parameters.Add(new SqlParameter("BrojKartice", klijent.PlatnaKartica.BrojKartice));
                command.ExecuteScalar();
            }
        }

        public void IzmeniAdresu(Adresa adresa)
        {

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"update dbo.Adresa
                set Drzava = @Drzava, Grad = @Grad,Ulica = @Ulica,Broj = @Broj where Id = @Id";

                command.Parameters.Add(new SqlParameter("Id", adresa.ID));
                command.Parameters.Add(new SqlParameter("Drzava", adresa.Drzava));
                command.Parameters.Add(new SqlParameter("Grad", adresa.Grad));
                command.Parameters.Add(new SqlParameter("Ulica", adresa.Ulica));
                command.Parameters.Add(new SqlParameter("Broj", adresa.Broj));
                command.ExecuteScalar();
            }
        }

        public void IzmeniPlatnuKarticu(PlatnaKartica kartica)
        {

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"update dbo.PlatnaKartica
                set BrojKartice = @BrojKartice, Iznos = @Iznos
                where BrojKartice = @BrojKartice";

                command.Parameters.Add(new SqlParameter("BrojKartice", kartica.BrojKartice));
                command.Parameters.Add(new SqlParameter("Iznos", kartica.Iznos));                  
                command.ExecuteScalar();
            }
        }

        public void IzmeniCiljeve(Klijent klijent, IList selektovaniCiljevi)
        {

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"delete from dbo.Ciljevi
                where KlijentEmail = @KlijentEmail";

                command.Parameters.Add(new SqlParameter("KlijentEmail", klijent.Email));
                command.ExecuteScalar();
                klijent.Ciljevi.Clear();

                foreach (string j in selektovaniCiljevi)
                {
                    string c = "select * from Ciljevi";

                    DataSet ds = new DataSet();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(c, conn);
                    dataAdapter.Fill(ds, "Ciljevi");


                    DataRow newRow = ds.Tables["Ciljevi"].NewRow();
                    newRow["KlijentEmail"] = klijent.Email;
                    newRow["Cilj"] = j;

                    ds.Tables["Ciljevi"].Rows.Add(newRow);

                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(ds.Tables["Ciljevi"]);

                    klijent.Ciljevi.Add(j);
                }
            }

        
        }

        public void IzmeniRekvizite(Klijent klijent, IList selektovaniRekviziti)
        {

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"delete from dbo.Rekviziti
                where KlijentEmail = @KlijentEmail";

                command.Parameters.Add(new SqlParameter("KlijentEmail", klijent.Email));
                command.ExecuteScalar();
                klijent.Rekviziti.Clear();

                foreach (string j in selektovaniRekviziti)
                {
                    string r = "select * from Rekviziti";

                    DataSet ds = new DataSet();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(r, conn);
                    dataAdapter.Fill(ds, "Rekviziti");


                    DataRow newRow = ds.Tables["Rekviziti"].NewRow();
                    newRow["KlijentEmail"] = klijent.Email;
                    newRow["Rekvizit"] = j;

                    ds.Tables["Rekviziti"].Rows.Add(newRow);

                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(ds.Tables["Rekviziti"]);

                    klijent.Rekviziti.Add(j);
                }
            }


        }

        public void IzmeniDodatneJezike(Object osoba, IList selektovaniJezici)
        {

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"delete from dbo.DodatniJezici
                where EmailOsobe = @EmailOsobe";
                
                if(osoba is Klijent)
                {
                    Klijent k = (Klijent)osoba;
                    
                    command.Parameters.Add(new SqlParameter("EmailOsobe", k.Email));
                    command.ExecuteScalar();
                    k.DodatniJezici.Clear();
                    
                    foreach (string j in selektovaniJezici)
                    {
                        string s = "select * from DodatniJezici";

                        DataSet ds = new DataSet();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(s, conn);
                        dataAdapter.Fill(ds, "DodatniJezici");


                        DataRow newRow = ds.Tables["DodatniJezici"].NewRow();
                        newRow["EmailOsobe"] = k.Email;
                        newRow["Jezik"] = j;

                        ds.Tables["DodatniJezici"].Rows.Add(newRow);

                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                        dataAdapter.Update(ds.Tables["DodatniJezici"]);

                        k.DodatniJezici.Add(j);
                    }
                }

                else if (osoba is Trener)
                {
                    Trener t = (Trener)osoba;

                    command.Parameters.Add(new SqlParameter("EmailOsobe", t.Email));
                    command.ExecuteScalar();
                    t.DodatniJezici.Clear();

                    foreach (string j in selektovaniJezici)
                    {
                        string s = "select * from DodatniJezici";

                        DataSet ds = new DataSet();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(s, conn);
                        dataAdapter.Fill(ds, "DodatniJezici");


                        DataRow newRow = ds.Tables["DodatniJezici"].NewRow();
                        newRow["EmailOsobe"] = t.Email;
                        newRow["Jezik"] = j;

                        ds.Tables["DodatniJezici"].Rows.Add(newRow);

                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                        dataAdapter.Update(ds.Tables["DodatniJezici"]);

                        t.DodatniJezici.Add(j);
                    }
                }
            }
        }

        public void IzmeniTrening(Trening trening)
        {

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"update dbo.Trening
                set TrenerEmail = @TrenerEmail,KlijentEmail = @KlijentEmail,DatumOdrzavanja = @DatumOdrzavanja,
                    VremePocetka = @VremePocetka, Trajanje = @Trajanje,Status = @Status,Cena = @Cena,
                    PlanTreninga = @PlanTreninga
                    where Id = @Id";


                command.Parameters.Add(new SqlParameter("Id", trening.ID));
                command.Parameters.Add(new SqlParameter("TrenerEmail", trening.Trener.Email));
                command.Parameters.Add(new SqlParameter("KlijentEmail", trening.Klijent.Email));
                command.Parameters.Add(new SqlParameter("DatumOdrzavanja", trening.DatumOdrzavanja));
                command.Parameters.Add(new SqlParameter("VremePocetka", trening.VremePocetka));
                command.Parameters.Add(new SqlParameter("Trajanje", trening.Trajanje));
                command.Parameters.Add(new SqlParameter("Status", trening.Status.ToString()));
                command.Parameters.Add(new SqlParameter("Cena", trening.Cena));
                command.Parameters.Add(new SqlParameter("PlanTreninga", trening.PlanTreninga));  
                command.ExecuteScalar();
            }
        }

        public void IzmeniOcene(Ocena ocena)
        {

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"update dbo.Ocena
                set Id = @Id,Pripada = @Pripada,Ocena = @Ocena,Komentar = @Komentar         
                where Id = @Id";


                command.Parameters.Add(new SqlParameter("Id", ocena.ID));
                command.Parameters.Add(new SqlParameter("Pripada", ocena.Pripada.Email));
                command.Parameters.Add(new SqlParameter("Ocena", ocena.Ocenaa));
                command.Parameters.Add(new SqlParameter("Komentar", ocena.Komentar));              
                command.ExecuteScalar();
            }
        }

        public void IzmeniZaraduAplikacije()
        {

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"update dbo.FitnesCentar
                set ZaradaAplikacije = @ZaradaAplikacije";
                
                    string s = "select * from FitnesCentar";

                    DataSet ds = new DataSet();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(s, conn);
                    dataAdapter.Fill(ds, "FitnesCentar");

                    if(ds.Tables["FitnesCentar"].Rows.Count == 0)
                    {                   
                        DataRow newRow = ds.Tables["FitnesCentar"].NewRow();
                        newRow["ZaradaAplikacije"] = 0;   
                        ds.Tables["FitnesCentar"].Rows.Add(newRow);  
                    
                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                        dataAdapter.Update(ds.Tables["FitnesCentar"]);                   

                    }

                command.Parameters.Add(new SqlParameter("ZaradaAplikacije", Instance.ZaradaAplikacije));
                command.ExecuteScalar();
            }
        }

        //-------------------------------------------------------------------------------


        public void SacuvajAdmina(Admin admin)
        {

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                string users = "select * from Admin";

                DataSet ds = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(users, conn);
                dataAdapter.Fill(ds, "Admin");


                DataRow newRow = ds.Tables["Admin"].NewRow();
                newRow["Ime"] = admin.Ime;
                newRow["Prezime"] = admin.Prezime;
                newRow["Email"] = admin.Email;
                newRow["Lozinka"] = admin.Lozinka;
                newRow["AdresaId"] = admin.Adresa.ID;
                newRow["BrojTelefona"] = admin.BrojTelefona;
                newRow["Pol"] = admin.Pol;
                

                ds.Tables["Admin"].Rows.Add(newRow);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(ds.Tables["Admin"]);

                
            }
        }

        public void SacuvajKlijenta(Klijent klijent)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                string users = "select * from Klijent";
                DataSet ds = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(users, conn);
                dataAdapter.Fill(ds, "Klijent");

                DataRow newRow = ds.Tables["Klijent"].NewRow();
                newRow["Ime"] = klijent.Ime;
                newRow["Prezime"] = klijent.Prezime;
                newRow["Email"] = klijent.Email;
                newRow["Lozinka"] = klijent.Lozinka;
                newRow["AdresaId"] = klijent.Adresa.ID;
                newRow["Pol"] = klijent.Pol;
                newRow["BrojTelefona"] = klijent.BrojTelefona;
                newRow["OsnovniJezik"] = klijent.OsnovniJezik;
                newRow["Visina"] = klijent.Visina;
                newRow["Tezina"] = klijent.Tezina;
                newRow["StanjaIBolesti"] = klijent.StanjaIBolesti;
                newRow["ObimKukova"] = klijent.ObimKukova;
                newRow["ObimStruka"] = klijent.ObimStruka;
                newRow["ObimGrudi"] = klijent.ObimGrudi;
                newRow["BrojKartice"] = klijent.PlatnaKartica.BrojKartice;

                ds.Tables["Klijent"].Rows.Add(newRow);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(ds.Tables["Klijent"]);


                foreach (string j in klijent.DodatniJezici)
                {
                    string s = "select * from DodatniJezici";

                    DataSet ds2 = new DataSet();
                    SqlDataAdapter dataAdapter2 = new SqlDataAdapter(s, conn);
                    dataAdapter2.Fill(ds2, "DodatniJezici");


                    DataRow newRow2 = ds2.Tables["DodatniJezici"].NewRow();
                    newRow2["EmailOsobe"] = klijent.Email;
                    newRow2["Jezik"] = j;

                    ds2.Tables["DodatniJezici"].Rows.Add(newRow2);

                    SqlCommandBuilder commandBuilder2 = new SqlCommandBuilder(dataAdapter2);
                    dataAdapter2.Update(ds2.Tables["DodatniJezici"]);


                }

                foreach (string j in klijent.Ciljevi)
                {
                    string s = "select * from Ciljevi";

                    DataSet ds3 = new DataSet();
                    SqlDataAdapter dataAdapter3 = new SqlDataAdapter(s, conn);
                    dataAdapter3.Fill(ds3, "Ciljevi");


                    DataRow newRow3 = ds3.Tables["Ciljevi"].NewRow();
                    newRow3["KlijentEmail"] = klijent.Email;
                    newRow3["Cilj"] = j;

                    ds3.Tables["Ciljevi"].Rows.Add(newRow3);

                    SqlCommandBuilder commandBuilder3 = new SqlCommandBuilder(dataAdapter3);
                    dataAdapter3.Update(ds3.Tables["Ciljevi"]);


                }

                foreach (string j in klijent.Rekviziti)
                {
                    string s = "select * from Rekviziti";

                    DataSet ds4 = new DataSet();
                    SqlDataAdapter dataAdapter4 = new SqlDataAdapter(s, conn);
                    dataAdapter4.Fill(ds4, "Rekviziti");


                    DataRow newRow4 = ds4.Tables["Rekviziti"].NewRow();
                    newRow4["KlijentEmail"] = klijent.Email;
                    newRow4["Rekvizit"] = j;

                    ds4.Tables["Rekviziti"].Rows.Add(newRow4);

                    SqlCommandBuilder commandBuilder4 = new SqlCommandBuilder(dataAdapter4);
                    dataAdapter4.Update(ds4.Tables["Rekviziti"]);


                }

            }
        }

        public void SacuvajAdresu(Adresa adresa)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                string users = "select * from Adresa";

                DataSet ds = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(users, conn);
                dataAdapter.Fill(ds, "Adresa");


                DataRow newRow = ds.Tables["Adresa"].NewRow();
                newRow["Id"] = adresa.ID;
                newRow["Drzava"] = adresa.Drzava;
                newRow["Grad"] = adresa.Grad;
                newRow["Ulica"] = adresa.Ulica;
                newRow["Broj"] = adresa.Broj;


                ds.Tables["Adresa"].Rows.Add(newRow);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(ds.Tables["Adresa"]);

               
            }
        }

        public void SacuvajOcenu(Ocena ocena)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                DataSet ds = new DataSet();
                string users = "select * from Ocena";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(users, conn);
                dataAdapter.Fill(ds, "Ocena");

                DataRow newRow = ds.Tables["Ocena"].NewRow();
                newRow["Id"] = ocena.ID;
                newRow["Pripada"] = ocena.Pripada.Email;
                newRow["Ocena"] = ocena.Ocenaa;
                newRow["Komentar"] = ocena.Komentar;

                ds.Tables["Ocena"].Rows.Add(newRow);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(ds.Tables["Ocena"]);

               
            }
        }

        public void SacuvajPlatnuKarticu(PlatnaKartica kartica)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                string users = "select * from PlatnaKartica";

                DataSet ds = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(users, conn);
                dataAdapter.Fill(ds, "PlatnaKartica");


                DataRow newRow = ds.Tables["PlatnaKartica"].NewRow();
                newRow["BrojKartice"] = kartica.BrojKartice;
                newRow["Iznos"] = kartica.Iznos;
                


                ds.Tables["PlatnaKartica"].Rows.Add(newRow);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(ds.Tables["PlatnaKartica"]);

                
            }
        }

        public void SacuvajTrenera(Trener trener)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                string users = "select * from Trener";

                DataSet ds = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(users, conn);
                dataAdapter.Fill(ds, "Trener");


                DataRow newRow = ds.Tables["Trener"].NewRow();
                newRow["Ime"] = trener.Ime;
                newRow["Prezime"] = trener.Prezime;
                newRow["Email"] = trener.Email;
                newRow["Lozinka"] = trener.Lozinka;
                newRow["AdresaId"] = trener.Adresa.ID;
                newRow["Pol"] = trener.Pol;
                newRow["BrojTelefona"] = trener.BrojTelefona;
                newRow["OsnovniJezik"] = trener.OsnovniJezik;
                newRow["Aktivan"] = trener.Aktivan;
                newRow["Zvanje"] = trener.Zvanje;
                newRow["BrojKartice"] = trener.PlatnaKartica.BrojKartice;


                ds.Tables["Trener"].Rows.Add(newRow);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(ds.Tables["Trener"]);
               

                

                    foreach (string j in trener.DodatniJezici)
                    {
                        string s = "select * from DodatniJezici";

                        DataSet ds2 = new DataSet();
                        SqlDataAdapter dataAdapter2 = new SqlDataAdapter(s, conn);
                        dataAdapter2.Fill(ds2, "DodatniJezici");


                        DataRow newRow2 = ds2.Tables["DodatniJezici"].NewRow();
                        newRow2["EmailOsobe"] = trener.Email;
                        newRow2["Jezik"] = j;

                        ds2.Tables["DodatniJezici"].Rows.Add(newRow2);

                        SqlCommandBuilder commandBuilder2 = new SqlCommandBuilder(dataAdapter2);
                        dataAdapter2.Update(ds2.Tables["DodatniJezici"]);

               
                    }
                

                
            }
        }

        public void SacuvajTrening(Trening trening)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                string users = "select * from Trening";

                DataSet ds = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(users, conn);
                dataAdapter.Fill(ds, "Trening");


                DataRow newRow = ds.Tables["Trening"].NewRow();
                newRow["Id"] = trening.ID;
                newRow["TrenerEmail"] = trening.Trener.Email;
                newRow["KlijentEmail"] = trening.Klijent.Email;
                newRow["DatumOdrzavanja"] = trening.DatumOdrzavanja;
                newRow["VremePocetka"] = trening.VremePocetka;
                newRow["Trajanje"] = trening.Trajanje;
                newRow["Status"] = trening.Status;
                newRow["Cena"] = trening.Cena;
                newRow["PlanTreninga"] = trening.PlanTreninga;
              
                ds.Tables["Trening"].Rows.Add(newRow);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(ds.Tables["Trening"]);
              
            }
        }



        //-------------------------------------------------------------------------------

        public void UcitajAdrese()
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                DataSet ds = new DataSet();

                string selectedUser = @"select * from Adresa";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectedUser, conn);
                dataAdapter.Fill(ds, "Adresa");

                foreach (DataRow dataRow in ds.Tables["Adresa"].Rows)
                {

                    Adresa adresa = new Adresa
                    {
                        ID = int.Parse(dataRow["Id"].ToString()),
                        Drzava = dataRow["Drzava"].ToString(),
                        Grad = dataRow["Grad"].ToString(),
                        Ulica = dataRow["Ulica"].ToString(),
                        Broj = int.Parse(dataRow["Broj"].ToString())


                    };
                    Instance.ListaAdresa.Add(adresa);
                }
            }

        }

        public void UcitajAdmina()
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                DataSet ds = new DataSet();

                string selectedUser = @"select * from Admin";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectedUser, conn);
                dataAdapter.Fill(ds, "Admin");

                foreach (DataRow dataRow in ds.Tables["Admin"].Rows)
                {
                    Enum.TryParse(dataRow["Pol"].ToString(), out EPol pol);

                    Admin admin = new Admin
                    {
                        Ime = dataRow["Ime"].ToString(),
                        Prezime = dataRow["Prezime"].ToString(),
                        Email = dataRow["Email"].ToString(),
                        Lozinka = dataRow["Lozinka"].ToString(),
                        Pol = pol,
                        BrojTelefona = dataRow["BrojTelefona"].ToString(),
                        Adresa = Instance.ListaAdresa.Find(a => a.ID.ToString().Equals(dataRow["AdresaId"].ToString()))
                                                                    
                    };
                    Instance.ListaAdmina.Add(admin);
                }
            }

        }
                    
        public void UcitajKlijenta()
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                DataSet ds = new DataSet();

                string selectedUser = @"select * from Klijent";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectedUser, conn);
                dataAdapter.Fill(ds, "Klijent");

                SqlCommand command1 = conn.CreateCommand();
                command1.CommandText = @"select Jezik from dbo.DodatniJezici
                where EmailOsobe = @EmailOsobe";

                SqlCommand command2 = conn.CreateCommand();
                command2.CommandText = @"select Cilj from dbo.Ciljevi
                where KlijentEmail = @KlijentEmail";

                SqlCommand command3 = conn.CreateCommand();
                command3.CommandText = @"select Rekvizit from dbo.Rekviziti
                where KlijentEmail = @KlijentEmail";

                foreach (DataRow dataRow in ds.Tables["Klijent"].Rows)
                {

                    Enum.TryParse(dataRow["Pol"].ToString(), out EPol pol);


                    command1.Parameters.Clear();
                    command2.Parameters.Clear();
                    command3.Parameters.Clear();

                    Klijent klijent = new Klijent
                    {
                        Ime = dataRow["Ime"].ToString(),
                        Prezime = dataRow["Prezime"].ToString(),
                        Email = dataRow["Email"].ToString(),
                        Lozinka = dataRow["Lozinka"].ToString(),
                        Adresa = Instance.ListaAdresa.Find(a => a.ID.ToString().Equals(dataRow["AdresaId"].ToString())),
                        Pol = pol,
                        Visina = float.Parse(dataRow["Visina"].ToString()),
                        Tezina = float.Parse(dataRow["Tezina"].ToString()),
                        StanjaIBolesti = dataRow["StanjaIBolesti"].ToString(),
                        ObimGrudi = float.Parse(dataRow["ObimGrudi"].ToString()),
                        ObimKukova = float.Parse(dataRow["ObimKukova"].ToString()),
                        ObimStruka = float.Parse(dataRow["ObimStruka"].ToString()),
                        OsnovniJezik = dataRow["OsnovniJezik"].ToString(),
                        BrojTelefona = dataRow["BrojTelefona"].ToString(),
                        PlatnaKartica = Instance.ListaPlatnihKartica.Find(a => a.BrojKartice.ToString().Equals(dataRow["BrojKartice"].ToString()))

                    };

                    command1.Parameters.Add(new SqlParameter("EmailOsobe", klijent.Email));
                    command2.Parameters.Add(new SqlParameter("KlijentEmail", klijent.Email));
                    command3.Parameters.Add(new SqlParameter("KlijentEmail", klijent.Email));

                    using (SqlDataReader reader = command1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            klijent.DodatniJezici.Add(reader[0].ToString());
                        }


                    }
                    using (SqlDataReader reader = command2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            klijent.Ciljevi.Add(reader[0].ToString());
                        }


                    }
                    using (SqlDataReader reader = command3.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            klijent.Rekviziti.Add(reader[0].ToString());
                        }


                    }

                    Instance.ListaKlijenata.Add(klijent);
                }
            }
        
        }

        public void UcitajTrenera()
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                DataSet ds = new DataSet();

                string selectedUser = @"select * from Trener";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectedUser, conn);
                dataAdapter.Fill(ds, "Trener");

                SqlCommand command1 = conn.CreateCommand();
                command1.CommandText = @"select Jezik from dbo.DodatniJezici
                where EmailOsobe = @EmailOsobe";
                  

                foreach (DataRow dataRow in ds.Tables["Trener"].Rows)
                {

                    Enum.TryParse(dataRow["Pol"].ToString(), out EPol pol);


                    command1.Parameters.Clear();
                    

                    Trener trener = new Trener
                    {
                        Ime = dataRow["Ime"].ToString(),
                        Prezime = dataRow["Prezime"].ToString(),
                        Email = dataRow["Email"].ToString(),
                        Lozinka = dataRow["Lozinka"].ToString(),
                        Adresa = Instance.ListaAdresa.Find(a => a.ID.ToString().Equals(dataRow["AdresaId"].ToString())),
                        Pol = pol,
                        Aktivan = Boolean.Parse(dataRow["Aktivan"].ToString()),
                        Zvanje = dataRow["Zvanje"].ToString(),                      
                        OsnovniJezik = dataRow["OsnovniJezik"].ToString(),
                        BrojTelefona = dataRow["BrojTelefona"].ToString(),
                        PlatnaKartica = Instance.ListaPlatnihKartica.Find(a => a.BrojKartice.ToString().Equals(dataRow["BrojKartice"].ToString()))

                    };

                    command1.Parameters.Add(new SqlParameter("EmailOsobe", trener.Email));                  
                    using (SqlDataReader reader = command1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            trener.DodatniJezici.Add(reader[0].ToString());
                        }


                    }
                    
                    Instance.ListaTrenera.Add(trener);
                }
            }

        }

        public void UcitajPlatnuKarticu()
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                DataSet ds = new DataSet();

                string selectedUser = @"select * from PlatnaKartica";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectedUser, conn);
                dataAdapter.Fill(ds, "PlatnaKartica");

                foreach (DataRow dataRow in ds.Tables["PlatnaKartica"].Rows)
                {
                   
                    PlatnaKartica kartica = new PlatnaKartica
                    {
                        BrojKartice = (dataRow["BrojKartice"].ToString()),
                        Iznos = float.Parse(dataRow["Iznos"].ToString())
                        

                    };
                    
                    Instance.ListaPlatnihKartica.Add(kartica);
                }
            }

        }

        public void UcitajOcene()
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                DataSet ds = new DataSet();

                string selectedUser = @"select * from Ocena";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectedUser, conn);
                dataAdapter.Fill(ds, "Ocena");

                foreach (DataRow dataRow in ds.Tables["Ocena"].Rows)
                {
                    Enum.TryParse(dataRow["Ocena"].ToString(), out EOcena o);

                    Ocena ocena = new Ocena
                    {
                        ID = int.Parse(dataRow["Id"].ToString()),
                        Ocenaa = o,
                        Komentar = dataRow["Komentar"].ToString(),
                        
                    };

                    Klijent k = Instance.ListaKlijenata.Find(a => a.Email.ToString().Equals(dataRow["Pripada"].ToString()));
                    Trener t = Instance.ListaTrenera.Find(a => a.Email.ToString().Equals(dataRow["Pripada"].ToString()));
                    if (k != null)
                    {
                        ocena.Pripada = k;
                        k.Ocene.Add(ocena);
                    }
                    else if (t != null)
                    {

                        ocena.Pripada = t;
                        t.Ocene.Add(ocena);
                    }
                    Instance.ListaOcena.Add(ocena);
                }
            }

        }

        public void UcitajTrening()
        {

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                DataSet ds = new DataSet();

                string selectedUser = @"select * from Trening";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectedUser, conn);
                dataAdapter.Fill(ds, "Trening");

                foreach (DataRow dataRow in ds.Tables["Trening"].Rows)
                {

                    Enum.TryParse(dataRow["Status"].ToString(), out EStatus status);

                    Trening trening = new Trening
                    {
                        ID = int.Parse(dataRow["Id"].ToString()),
                        Trener = Instance.ListaTrenera.Find(t => t.Email.Equals(dataRow["TrenerEmail"].ToString())),
                        Klijent = Instance.ListaKlijenata.Find(k => k.Email.Equals(dataRow["KlijentEmail"].ToString())),
                        DatumOdrzavanja = DateTime.Parse(dataRow["DatumOdrzavanja"].ToString()),
                        VremePocetka = dataRow["VremePocetka"].ToString(),
                        Trajanje = int.Parse(dataRow["Trajanje"].ToString()),
                        Status = status,
                        Cena = float.Parse(dataRow["Cena"].ToString()),
                        PlanTreninga = dataRow["PlanTreninga"].ToString()


                    };
                    if (trening.Klijent == null)
                    {
                        trening.Klijent = new Klijent();
                    }
                    else
                    {
                        trening.Trener.SviKlijenti.Add(trening.Klijent);
                        trening.Klijent.ZakazaniTreninzi.Add(trening);

                    }
                    Instance.ListaTreninga.Add(trening);
                    trening.Trener.SviTreninzi.Add(trening);                   
                    
                }
            }

        }

        public void UcitajFitnesCentar()
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                DataSet ds = new DataSet();

                string selectedUser = @"select * from FitnesCentar";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectedUser, conn);
                dataAdapter.Fill(ds, "FitnesCentar");

               
                foreach (DataRow dataRow in ds.Tables["FitnesCentar"].Rows)
                {

                    Instance.ZaradaAplikacije = float.Parse(dataRow["ZaradaAplikacije"].ToString());
     
                }
            }

        }

        //-------------------------------------------------------------------------------

        public void Obrisi(Object obj)
        {

            if(obj is Klijent && obj != null)
            {
                Klijent klijent = (Klijent)obj;

                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    SqlCommand command = conn.CreateCommand();
                    command.CommandText = @"delete from Klijent                                      
                                        where Email = @Email";
                    command.Parameters.Add(new SqlParameter("Email", klijent.Email));
                    command.ExecuteNonQuery();
                    //... u svakoj tabeli gde se pojavljuje klijent obrisati taj podatak

                }
            }


           

           
        }
    }
}
