using SSS_2022_projekat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS_2022_projekat.Model
{
    public abstract class Osoba
    {

        public Osoba(string ime, string prezime, string email, string lozinka, EPol pol, string brojTelefona, Adresa adresa)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.lozinka = lozinka;
            this.pol = pol;
            this.brojTelefona = brojTelefona;
            this.adresa = adresa;
        }

        public Osoba()
        {
            this.ime = "";
            this.prezime = "";
            this.email = "";
            this.lozinka = "";
            this.pol = EPol.MUSKI;
            this.brojTelefona = "";
            this.adresa = new Adresa();
        }

        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        private string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string lozinka;
        public string Lozinka
        {
            get { return lozinka; }
            set { lozinka = value; }
        }
        private EPol pol;
        public EPol Pol
        {
            get { return pol; }
            set { pol = value; }
        }

        private string brojTelefona;
        public string BrojTelefona
        {
            get { return brojTelefona; }
            set { brojTelefona = value; }
        }

        private Adresa adresa;
        public Adresa Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }


    }
}
