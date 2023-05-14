using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS_2022_projekat.Model
{
    public class Trener:Osoba
    {
        public Trener(string ime, string prezime, string email, string lozinka, EPol pol, string brojTelefona, Adresa adresa, string osnovniJezik, List<string> dodatniJezici, bool aktivan, string zvanje, List<Klijent> sviKlijenti, List<Trening> sviTreninzi, PlatnaKartica platnaKartica, List<Ocena> ocene) : base(ime, prezime, email, lozinka, pol, brojTelefona, adresa)
        {
            this.osnovniJezik = osnovniJezik;
            this.dodatniJezici = dodatniJezici;
            this.aktivan = aktivan;
            this.zvanje = zvanje;
            this.sviKlijenti = sviKlijenti;
            this.sviTreninzi = sviTreninzi;
            this.platnaKartica = platnaKartica;
            this.ocene = ocene;
        }

        public Trener()
        {
            this.osnovniJezik = "";
            this.dodatniJezici = new List<string>();
            this.aktivan = false;
            this.zvanje = "";
            this.sviKlijenti = new List<Klijent>();
            this.sviTreninzi = new List<Trening>();
            this.platnaKartica = new PlatnaKartica();
            this.ocene = new List<Ocena>();
        }

        private string osnovniJezik;
        public string OsnovniJezik
        {
            get { return osnovniJezik; }
            set { osnovniJezik = value; }
        }

        private List<string> dodatniJezici;
        public List<string> DodatniJezici
        {
            get { return dodatniJezici; }
            set { dodatniJezici = value; }
        }
        private Boolean aktivan = false;
        public Boolean Aktivan
        {
            get { return aktivan; }
            set { aktivan = value; }
        }
        private string zvanje;
        public string Zvanje
        {
            get { return zvanje; }
            set { zvanje = value; }
        }
        private List<Klijent> sviKlijenti;
        public List<Klijent> SviKlijenti
        {
            get { return sviKlijenti; }
            set {   sviKlijenti = value; }
        }

        private List<Trening> sviTreninzi;
        public List<Trening> SviTreninzi
        {
            get { return sviTreninzi; }
            set { sviTreninzi = value; }
        }
        private PlatnaKartica platnaKartica;
        public PlatnaKartica PlatnaKartica
        {
            get { return platnaKartica; }
            set { platnaKartica = value; }
        }
        private List<Ocena> ocene;

        public List<Ocena> Ocene
        {
            get { return ocene; }
            set { ocene = value; }
        }

  
        public void oceniKlijenta(Klijent k,Ocena o)
        {
            k.Ocene.Add(o);
        }

        public override string ToString()
        {
            return "Name: " + Ime + " , " + "Last name: " + Prezime + " , " + "Vocation: " + Zvanje + " , " + "Email: " + Email + " , " + "Language: " + OsnovniJezik + " , " + "Phone number: " + BrojTelefona;
        }
    }
}
