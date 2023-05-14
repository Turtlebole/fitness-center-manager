using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS_2022_projekat.Model
{
    public class Admin : Osoba
    {
        public Admin()
        {
        }

        public Admin(string ime, string prezime, string email, string lozinka, EPol pol, string brojTelefona, Adresa adresa) : base (ime,  prezime,  email,  lozinka,  pol,  brojTelefona, adresa)
        {
            
        }

        public void aktivirajTrenera(Trener t)
        {
            t.Aktivan = true;
            
        }
    }
}
