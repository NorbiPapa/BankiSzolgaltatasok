using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    internal class MegtakarításiSzámla : Számla
    {

        private double kamat;
        private static double alapkamat = 1.1;


        public MegtakarításiSzámla(Tulajdonos tulajdonos) : base(tulajdonos)
        {
            this.kamat = alapkamat;
        }

        public double getKamat()
        {
            return kamat;
        }

        public void setKamat(double kamat)
        {
            this.kamat = kamat;
        }

        public override bool Kivesz(int osszeg)
        {
            bool sikerult;
            if (this.aktualisegyenleg - osszeg <= 0)
            {
                sikerult = false;
            }
            else
            {
                this.aktualisegyenleg -= osszeg;
                sikerult = true;
            }
            return sikerult;
        }

        public void KamatJóváírás()
        {
            this.aktualisegyenleg = (int)(this.aktualisegyenleg * kamat);
        }


    }
}
