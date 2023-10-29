using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    internal class Kártya : BankiSzolgáltatás
    {
        private Számla szamla;
        private string kartyaSzam;

        public Kártya(Tulajdonos tulajdonos, Számla szamla, string kartyaSzam) : base(tulajdonos)
        {
            tulajdonos = Tulajdonos;
            this.szamla = szamla;
            this.kartyaSzam = kartyaSzam;
        }


        public string KartyaSzam()
        {
            return this.kartyaSzam;
        }


        public bool Vasarlas(int osszeg)
        {
            bool sikerult;
            if (szamla.AktualisEgyenleg - osszeg < 0)
            {
                sikerult = false;
            }
            else
            {
                szamla.Kivesz(osszeg);
                sikerult = true;
            }
            return sikerult;
        }
    }
}
