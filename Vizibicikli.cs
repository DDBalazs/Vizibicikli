namespace HELL
{
    internal class Vizibicikli
    {
        public string Nev;
        public string JAzon;
        public int Eora;
        public int Eperc;
        public int Vora;
        public int Vperc;

        public Vizibicikli (string sor)
        {
            var dbok = sor.Split(';');
            this.Nev = dbok[0];
            this.JAzon = dbok[1];
            this.Eora = int.Parse (dbok[2]);
            this.Eperc = int.Parse (dbok[3]);
            this.Vora = int.Parse (dbok[4]);
            this.Vperc = int.Parse (dbok [5]);
        }
    }
}