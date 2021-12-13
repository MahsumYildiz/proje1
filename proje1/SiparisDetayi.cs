using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
    public class SiparisDetayi
    {
        public int miktar { get; set; }
        public int vergidurumu { get; set; }
        private Siparis _siparis;
        public SiparisDetayi(Siparis siparis)
        {
            this._siparis = siparis;

        }
        public void VergiHesabi()
        {

        }
        public void AğirlikHesabi()
        {

        }

    }
}
