using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Narudzba
{
    internal class Narudzba
    {
        public delegate void PredajNarudzbu(Narudzba narudzba);
        public event PredajNarudzbu NarudzbaPredana;
        public string Naziv { get; set; }

        public void KreirajNarudzbu()
        {
            Console.WriteLine("Narudžba {0} naručena.", this.Naziv);
            Console.WriteLine("Narudžba {0} je predna distributeru.", this.Naziv);

            NarudzbaPredana?.Invoke(this);
        }
    }
}
