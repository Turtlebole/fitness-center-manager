using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS_2022_projekat.Model
{
    public class Klijent:Osoba
    {
        public Klijent(string ime, string prezime, string email, string lozinka, EPol pol, string brojTelefona, Adresa adresa, string osnovniJezik, List<string> dodatnijezici, float visina, float tezina, string stanjaIBolesti, List<string> ciljevi, List<string> rekviziti, float obimKukova, float obimStruka, float obimGrudi, List<Trening> zakazaniTreninzi, List<Ocena> ocene, PlatnaKartica platnaKartica) : base(ime, prezime, email, lozinka, pol, brojTelefona, adresa)
        {
            this.osnovniJezik = osnovniJezik;
            this.dodatnijezici = dodatnijezici;
            this.visina = visina;
            this.tezina = tezina;
            this.stanjaIBolesti = stanjaIBolesti;
            this.ciljevi = ciljevi;
            this.rekviziti = rekviziti;
            this.obimKukova = obimKukova;
            this.obimStruka = obimStruka;
            this.obimGrudi = obimGrudi;
            this.zakazaniTreninzi = zakazaniTreninzi;
            this.ocene = ocene;
            this.platnaKartica = platnaKartica;
        }

        public Klijent()
        {
            this.osnovniJezik = "";
            this.dodatnijezici = new List<string>();
            this.visina = 0;
            this.tezina = 0;
            this.stanjaIBolesti = "";
            this.ciljevi = new List<string>(); 
            this.rekviziti = new List<string>(); 
            this.obimKukova = 0;
            this.obimStruka = 0;
            this.obimGrudi = 0;
            this.zakazaniTreninzi = new List<Trening>(); 
            this.ocene = new List<Ocena>(); 
            this.platnaKartica = new PlatnaKartica();
        }

        private string osnovniJezik;
        public string OsnovniJezik
        {
            get { return osnovniJezik; }
            set { osnovniJezik = value; }
        }
        private List<string> dodatnijezici;
        public List<string> DodatniJezici
        {
            get { return dodatnijezici; }
            set { dodatnijezici = value; }
        }
    
        private float visina;
        public float Visina
        { 
            get { return visina; } 
            set { visina = value; }
        }
        private float tezina;
        public float Tezina
        {
            get { return tezina; } set { tezina = value; } 
        }
        private string stanjaIBolesti;
        public string StanjaIBolesti
        {
            get { return stanjaIBolesti; }
            set { stanjaIBolesti = value; }
        }
        private List<string> ciljevi;
        public List<string> Ciljevi
        {
            get { return ciljevi; }
            set{ ciljevi = value; }
        }
        private List<string> rekviziti;
        public List<string> Rekviziti
        {
            get { return rekviziti; }
            set { rekviziti = value; }
        }
        private float obimKukova;
        public float ObimKukova
        {
            get { return obimKukova; } set { obimKukova = value; } 
        }
        private float obimStruka;
        public float ObimStruka
        {
            get { return obimStruka; }
            set { obimStruka = value; } 
        }
        private float obimGrudi;
        public float ObimGrudi
        {
            get { return obimGrudi; }
            set { obimGrudi = value; }
        }

        private List<Trening> zakazaniTreninzi;
        public List<Trening> ZakazaniTreninzi
        {
            get { return zakazaniTreninzi; }
            set { zakazaniTreninzi = value; }
        }
        private List<Ocena> ocene;
        public List<Ocena> Ocene
        {
            get { return ocene; } set { ocene = value; }
        }

        private PlatnaKartica platnaKartica;

        public PlatnaKartica PlatnaKartica
        {
            get { return platnaKartica; }
            set { platnaKartica = value; }
        }

        public void platiTrening(Trening t)
        {
            if(PlatnaKartica.Iznos >= t.Cena)
            {
                PlatnaKartica.Iznos = PlatnaKartica.Iznos - t.Cena;
                t.Trener.PlatnaKartica.Iznos = (float)(t.Trener.PlatnaKartica.Iznos + (t.Cena * 0.95));
                FitnesCentar.Instance.ZaradaAplikacije = (float)(FitnesCentar.Instance.ZaradaAplikacije + (t.Cena * 0.05));

            }
        }

        public void dodajNovacNaKarticu(float iznos)
        {
            PlatnaKartica.Iznos = PlatnaKartica.Iznos + iznos;
        }

        public void otkaziTrening(Trening t)
        {
            ZakazaniTreninzi.Remove(t);
            t.Klijent = new Klijent();
            t.Status = EStatus.SLOBODAN;

        }
        public void rezervisiTrening(Trening t)
        {
            t.Klijent = this;
            ZakazaniTreninzi.Add(t);
            t.Status = EStatus.REZERVISAN;

        }

        public void oceniTrenera(Trener t, Ocena o)
        {
            t.Ocene.Add(o);
        }

        public override string ToString()
        {
            return "Name: " + Ime + " , " + "Last name: " + Prezime + " , " + "Email: " + Email + " , " + "Languages: " + DodatniJezici + " , " + "Phone number: " + BrojTelefona;
        }
    }
}
