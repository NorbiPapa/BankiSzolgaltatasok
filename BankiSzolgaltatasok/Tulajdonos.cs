using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public sealed class Tulajdonos
    {
        private string nev;

        public Tulajdonos(string nev)
        {
            this.nev = nev;
        }

        public string getNev()
        {
            return this.nev;
        }

        public string setNev(string nev)
        {
            return this.nev = nev;
        }
    }
}
