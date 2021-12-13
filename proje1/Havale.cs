using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
    public  class Havale:odeme
    {
        public string isim { get; set; }
        public long BankaID { get; set; }
        public override void  Odeme() 
        {
            Console.WriteLine("Havale ile ödendi");
        
        }

    }
}
