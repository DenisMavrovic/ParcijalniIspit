using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Narudzba
{
    internal class Program
    {
        public delegate void NarudzbaNarucena(DateTime vrijemeNarudzbe);
        static void Main(string[] args)
        {
            Narudzba narudzba1 = new Narudzba();
            Narudzba narudzba2 = new Narudzba();
            Distributer distributer = new Distributer();

            narudzba1.NarudzbaPredana += PretplacenaMetoda;
            narudzba2.NarudzbaPredana += PretplacenaMetoda;
            distributer.NarudzbaUIsporuci += Distributer_NarudzbaUIsporuci;

            narudzba1.Naziv = "Banana";
            narudzba2.Naziv = "Jabuka";            
            PretplacenaMetoda(narudzba1);
            PretplacenaMetoda(narudzba2);
            // ovo liniju niže je potrebno otkomentirati jer se preko nje poziva event koji poziva Distributer_NadrudzbaUIsporuci pretplaćenu metodu
            //distributer.KrecemSDostavom();
            
            // ovu pretplacenu metodu ne pozivamo direktno nego kroz event u distributer.KrecemSDostavom();
            Distributer_NarudzbaUIsporuci(DateTime.Now);
            

            Console.ReadKey();
        }

        private static void Distributer_NarudzbaUIsporuci(DateTime vrijeme)
        {
            Console.WriteLine("brmm, brmm... Kamion je krenio. brmm, brmm....");
            Console.WriteLine("Narudžba je istovarena u kamion i krenuo {0}", vrijeme);
        }

        private static void PretplacenaMetoda(Narudzba narudzba)
        {
            Console.WriteLine("Narudžba {0} naručena.", narudzba.Naziv);
            Console.WriteLine("Narudžba {0} je predna distributeru.", narudzba.Naziv);
        }
    }
}
