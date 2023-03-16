using System.IO;
using System.Text;

namespace HELL
{
    class Program
    {
        static List<Vizibicikli> Vizi_List = new List<Vizibicikli>();
        static void Main(string[] args)
        {
            Feladat4(); Console.WriteLine("--------------------------------------");
            Feladat5(); Console.WriteLine("--------------------------------------");
            Feladat6(); Console.WriteLine("--------------------------------------");
            Feladat7(); Console.WriteLine("--------------------------------------");
            Feladat8(); Console.WriteLine("--------------------------------------");

        }

        static void Feladat8()
        {
            Console.WriteLine("Feladat 8: Napi bevétel");
            int osszido = 0;
            foreach(var k in Vizi_List)
            {
                int kezdiod = k.Eora * 60 + k.Eperc;
                int vegido = k.Vora * 60 + k.Vperc;
                int ido = vegido - kezdiod;
                {
                    int TeljesFelora = ido / 30;
                    int maradek = ido % 30;
                    if(0<maradek || maradek < 30)
                    {
                        osszido++;
                    }
                }
            }
        }
        static void Feladat7()
        {
            Console.WriteLine("Kérem adjon meg egy időpontot: (óra:perc)");
            string bekert = Console.ReadLine();
            var reszek = bekert.Split(':');
            int bekertora = int.Parse(reszek[0]);
            int bekerperc = int.Parse(reszek[1]);
            int bekerido = bekertora * 60 + bekerperc;
            foreach (var k in Vizi_List)
            {
                if(k.Eora * 60 +k.Eperc< bekerido || k.Vora * 60 +k.Vperc< bekerido){
                    Console.WriteLine($"\t{k.Eora} : {k.Eperc} - {k.Vora} : {k.Vperc} : {k.Nev}");
                }
            }
        }
        static void Feladat6()
        {
            Console.WriteLine("6. Feladat: Bekérés + keresés");
            Console.WriteLine("\nKérem adjon meg egy nevet: ");
            string knev = Console.ReadLine();
            int db = 0;
            foreach(var v in Vizi_List)
            {
                if(knev == v.Nev)
                {
                    db++;
                    Console.WriteLine($"{v.Eora}: {v.Eperc} - {v.Vora}: {v.Vperc}");
                }
            }
            if(db == 0)
            { Console.WriteLine("Nem volt ilyen nevű kölcsönző"); }
        }
        static void Feladat5()
        {
            Console.WriteLine($"Beolvasott sorok száma: {Vizi_List.Count}");
        }
        static void Feladat4()
        {
            var sr = new StreamReader(@"kolcsonzesek.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                Vizi_List.Add(new Vizibicikli(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}