using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    internal class Hitelszámla : Számla
    {

        private int hitelkeret;
        public Hitelszámla(Tulajdonos tulajdonos, int hitelkeret) : base(tulajdonos)
        {
            this.hitelkeret = hitelkeret;
        }

        public override bool Kivesz(int osszeg)
        {
            bool sikerult;
            if (osszeg > hitelkeret + AktualisEgyenleg)
            {
                sikerult = false;
            }
            else
            {
                aktualisegyenleg -= osszeg;
                sikerult = true;
            }
            return sikerult;
        }
    }
}
