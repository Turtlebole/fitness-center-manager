namespace SSS_2022_projekat.Model
{
    public class Ocena
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private EOcena ocenaa;
        public EOcena Ocenaa { get => ocenaa; set => ocenaa = value; }

        private string komentar;
        public string Komentar 
        {
            get { return komentar; } 
            set { komentar = value; } 
        }

        private Osoba pripada;
        public Osoba Pripada
        {
            get { return pripada; }
            set { pripada = value; }
        }

        public Ocena(int id, EOcena ocenaa, string komentar, Osoba pripada)
        {
            this.id = id;
            this.ocenaa = ocenaa;
            this.komentar = komentar;
            this.pripada = pripada;
        }

        public Ocena(EOcena ocenaa, string komentar, Osoba pripada)
        {
            this.ocenaa = ocenaa;
            this.komentar = komentar;
            this.pripada = pripada;
        }

        public Ocena()
        {
            this.id = 0;
            this.ocenaa = EOcena.A;
            this.komentar = "";
           
        }
    }
}
