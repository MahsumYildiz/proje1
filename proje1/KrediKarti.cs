using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
   public class KrediKarti : odeme
    {
        public int ibanno { get; set; }
        public int sonkullanmatarihi { get; set; }
        public string karttipi { get; set; }
        public override void Odeme()
        {
            Console.WriteLine("Kredi Kartı ile ödendi");

        }
    }
}
