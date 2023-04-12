using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Narudzba
{
    internal class Distributer
    {
        public delegate void NarudzbaNarucena(DateTime dateTime);
        public event NarudzbaNarucena NarudzbaUIsporuci;

        //public void KrecemSDostavom(DateTime vrijeme)
        public void KrecemSDostavom()
        {
            Console.WriteLine("brmm, brmm... Kamion je krenio. brmm, brmm....");
            //Console.WriteLine("Narudžba je istovarena u kamion i krenuo {0}", vrijeme);

            NarudzbaUIsporuci?.Invoke(DateTime.Now);
        }
    }
}
