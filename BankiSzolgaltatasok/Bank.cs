using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    internal class Bank
    {
        private List<Számla> szamlaLista;
        private int listaMeret;
        private int osszHitelKeret;

        public Bank()
        {
            this.szamlaLista = new List<Számla>(this.listaMeret);
        }

        public Számla szamlanyitas(int hitelKeret, Tulajdonos tulajdonos)
        {
            if (hitelKeret < 0)
            {
                Hitelszámla h = new Hitelszámla(tulajdonos, hitelKeret);
                szamlaLista.Add(h);
                return h;
            }
            else
            {
                MegtakarításiSzámla m_sz = new MegtakarításiSzámla(tulajdonos);
                szamlaLista.Add(m_sz);
                return m_sz;
            }
        }

        public int GetÖsszEgyenleg(Tulajdonos tulajdonos)
        {
            int ossz = 0;


            for (int i = 0; i < szamlaLista.Count; i++)
            {
                if (szamlaLista[i].Tulajdonos == tulajdonos)
                {
                    ossz += szamlaLista[i].AktualisEgyenleg;
                }
            }
            return ossz;
        }

        public Számla GetLegnagyobbEgyenlegűSzámla(Tulajdonos tulajdonos, Számla m_szamla)
        {
            Számla sz = this.szamlaLista[0];
            int maxEgyenleg = 0;
            foreach (Számla item in szamlaLista)
            {
                if (item.Tulajdonos == tulajdonos && maxEgyenleg < item.AktualisEgyenleg)
                {
                    sz = item;
                    maxEgyenleg = item.AktualisEgyenleg;
                }
            }
            return sz;
        }

        public long ÖsszHitelkeret()
        {
            return this.osszHitelKeret;
        }



    }
}





