    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS_2022_projekat.Model
{
    public class PlatnaKartica
    {
        private string brojKartice;
        public string BrojKartice
        {
            get { return brojKartice; }
            set { brojKartice = value; }
        }
   
        private float iznos;
        public float Iznos { get => iznos; set => iznos = value; }    


        public PlatnaKartica(string brojKartice, float iznos)
        {
            this.brojKartice = brojKartice;
            this.iznos = iznos;
           
        }
        public PlatnaKartica()
        {
            this.brojKartice = "0";
            this.iznos = 0;

        }

        public override string ToString()
        {
            return "Card number: " + BrojKartice + " , " + "Amount: " + Iznos;
        }
    }
}
