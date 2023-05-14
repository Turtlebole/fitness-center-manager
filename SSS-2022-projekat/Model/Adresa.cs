using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS_2022_projekat.Model
{
    public class Adresa
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string drzava;
        public string Drzava
        {
            get { return drzava; }
            set { drzava = value; }
        }

        private string grad;
        public string Grad
        {
            get { return grad; }
            set { grad = value; }
        }
        private string ulica;
        public string Ulica
        {
            get { return ulica; }
            set { ulica = value; }
        }
        private int broj;
        public int Broj
        {
            get { return broj; }
            set { broj = value; }
        }

        public Adresa(int id,string drzava, string grad, string ulica, int broj)
        {
            this.id = id;
            this.drzava = drzava;
            this.grad = grad;
            this.ulica = ulica;
            this.broj = broj;
        }

        public Adresa(string drzava, string grad, string ulica, int broj)
        {     
            this.drzava = drzava;
            this.grad = grad;
            this.ulica = ulica;
            this.broj = broj;
        }

        public Adresa()
        {
            this.id = 0;
            this.drzava = "";
            this.grad = "";
            this.ulica = "";
            this.broj = 0;
        }
    }
}
