using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Narudzba
{
    internal class Program
    {
        public delegate DateTime NarudzbaNarucena();
        static void Main(string[] args)
        {
            Narudzba narudzba1 = new Narudzba();
            Narudzba narudzba2 = new Narudzba();
            Distributer distributer = new Distributer();

            narudzba1.Naziv = "Banana";
            narudzba2.Naziv = "Jabuka";
            narudzba1.KreirajNarudzbu();
            narudzba2.KreirajNarudzbu();
            distributer.KrecemSDostavom(DateTime.Now);

            Console.ReadKey();
        }
    }
}
