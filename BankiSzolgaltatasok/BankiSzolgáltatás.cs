using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public abstract class BankiSzolgáltatás
    {
        private Tulajdonos tulajdonos;
        public BankiSzolgáltatás(Tulajdonos tulajdonos)
        {
            this.tulajdonos = tulajdonos;
        }

        public Tulajdonos Tulajdonos { get => tulajdonos; }




    }
}
