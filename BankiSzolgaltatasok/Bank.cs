using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class Bank
    {
        List<Szamla> szamlaLista = new List<Szamla>();

        public Bank()
        {
        }

        public int OsszHitelkeret 
        {
            get
            {
                int osszHitelkeret = 0;
                foreach (var item in szamlaLista)
                {
                    if (item is HitelSzamla hitelSzamla)
                    {
                        osszHitelkeret += hitelSzamla.HitelKeret;
                    }
                }
                return osszHitelkeret;
            }
        }

        public Szamla SzamlaNyitas(Tulajdonos tulajdonos, int hitelKeret)
        {
            if (hitelKeret < 0)
            {
                throw new ArgumentException("A hitelkeret nem lehet 0-nál kisebb érték!",nameof(hitelKeret));
            }
            else
            {
                if (hitelKeret == 0)
                {
                    Szamla szamla = new MegtakaritasiSzamla(tulajdonos);
                    szamlaLista.Add(szamla);
                    return szamla;
                }
                else
                {
                    Szamla szamla = new HitelSzamla(tulajdonos, hitelKeret);
                    szamlaLista.Add(szamla);
                    return szamla;
                }
            }
        }

        public long GetOsszEgyenleg(Tulajdonos tulajdonos)
        {
            int osszEgyenleg = 0;
            foreach (var item in szamlaLista)
            {
                if (item.Tulajdonos == tulajdonos)
                {
                    osszEgyenleg += item.AktualisEgyenleg;
                }
            }
            return osszEgyenleg;
        }

        public Szamla GetLegnagyobbEgyenleguSzamla(Tulajdonos tulajdonos)
        {
            int maxOsszeg = szamlaLista[0].AktualisEgyenleg;
            int index = 0;
            for (int i = 1; i < szamlaLista.Count; i++)
            {
                if (szamlaLista[i].AktualisEgyenleg > maxOsszeg)
                {
                    maxOsszeg = szamlaLista[i].AktualisEgyenleg;
                    index = i;
                }
            }
            return szamlaLista[index];
        }
    }
}
