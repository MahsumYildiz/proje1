using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
    public class Pesin : odeme
    {
        public int nakit { get; set; }
        public override void Odeme()
        {
            Console.WriteLine("Peşin ödendi");
        }
    }
}
