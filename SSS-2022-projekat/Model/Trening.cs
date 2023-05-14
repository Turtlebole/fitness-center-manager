using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SSS_2022_projekat.Model
{
    public class Trening
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime datumOdrzavanja;
        public DateTime DatumOdrzavanja
        {
            get { return datumOdrzavanja; }
            set { datumOdrzavanja = value; }
        }

        private string vremePocetka;
        public string VremePocetka
        {
            get { return vremePocetka; }
            set { vremePocetka = value; }
        }
        private int trajanje;
        public int Trajanje
        {
            get { return trajanje; }
            set { trajanje = value; }
        }
        private EStatus status;
        public EStatus Status
        {
            get { return status; }
            set { status = value; }
        }
        private float cena;
        public float Cena
        {
            get { return cena; }
            set { cena = value; }
        }
        private string planTreninga;
        public string PlanTreninga
        {
            get { return planTreninga; }
            set
            { planTreninga = value; }
        }
        private Trener trener;
        public Trener Trener
        {
            get { return trener; }
            set { trener = value; }   
        }
        private Klijent klijent;
        public Klijent Klijent
        {
            get { return klijent; }
            set { klijent = value; }
        }

        public Trening(int id, DateTime datumOdrzavanja, string vremePocetka, int trajanje, EStatus status, float cena, string planTreninga, Trener trener, Klijent klijent)
        {
            this.id = id;
            this.datumOdrzavanja = datumOdrzavanja;
            this.vremePocetka = vremePocetka;
            this.trajanje = trajanje;
            this.status = status;
            this.cena = cena;
            this.planTreninga = planTreninga;
            this.trener = trener;
            this.klijent = klijent;
        }

        public Trening(DateTime datumOdrzavanja, string vremePocetka, int trajanje, EStatus status, float cena, string planTreninga, Trener trener, Klijent klijent)
        {
            this.datumOdrzavanja = datumOdrzavanja;
            this.vremePocetka = vremePocetka;
            this.trajanje = trajanje;
            this.status = status;
            this.cena = cena;
            this.planTreninga = planTreninga;
            this.trener = trener;
            this.klijent = klijent;
        }

        public Trening()
        {
            this.id = 0;
            this.datumOdrzavanja = DateTime.Now;
            this.vremePocetka = "";
            this.trajanje = 0;
            this.status = EStatus.SLOBODAN;
            this.cena = 0;
            this.planTreninga = "";
            this.trener = new Trener();
            this.klijent = new Klijent();
        }

        public override string ToString()
        {
            return "Coach: " + Trener + " , " + "Date: " + DatumOdrzavanja + " , " + "Time: " + VremePocetka + " , " + "Duration: " + Trajanje + " , " + "Price: " + Cena;
        }
    }
}
