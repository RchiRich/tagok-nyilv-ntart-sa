using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tagok_nyilvántartása
{
    internal class Tagok
    {
        public int azon;
        public string nev;
        public int szulev;
        public int irszam;
        public string orsz;

        public Tagok(int azon, string nev, int szulev, int irszam, string orsz)
        {
            this.azon = azon;
            this.nev = nev;
            this.szulev = szulev;
            this.irszam = irszam;
            this.orsz = orsz ;
        }
        public override string ToString()
        {
            return $"Név:{nev}\nAzonosító:{azon}\nSzületési év:{szulev}\nIrányítószám{irszam}\nOrszág{orsz}\n___________";
        }
    }
}
