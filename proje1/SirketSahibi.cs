using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace proje1
{
    public class SirketSahibi
    {
        public int UrunSayisi { get; set; }
        public string Urunadi { get; set; }
        public string veriler { get; set; }

        private List<SirketSahibi> Oku()
        {
            var list = new List<string>();
            list = File.ReadAllLines("C:\\Users\\90534\\Desktop\\Deneme2.txt").ToList();

            // var list2 = new List<SirketSahibi>();
            //foreach (var item in list)
            //{
            //    var r = JsonConvert.DeserializeObject<SirketSahibi>(item);
            //    list2.Add(r);
            //}

            //return list2;
            var result = JsonConvert.DeserializeObject<List<SirketSahibi>>(File.ReadAllText("C:\\Users\\90534\\Desktop\\Deneme2.txt"));
            return result != null ? result : new List<SirketSahibi>();
        }
        private void Yaz(List<SirketSahibi> list)
        {
            //var result = new List<string>();
            //foreach (var item in list)
            //{
            //    result.Add(JsonConvert.SerializeObject(item));
            //}
            //File.WriteAllLines("C:\\Users\\90534\\Desktop\\Deneme2.txt", result);
            File.WriteAllText("C:\\Users\\90534\\Desktop\\Deneme2.txt", JsonConvert.SerializeObject(list));
        }
        public void UrunCikar()
        {
            var list2 = Oku();
            var d = list2.FirstOrDefault(s => s.Urunadi == Urunadi);

            d.UrunSayisi -= UrunSayisi;
            Yaz(list2);


        }
        public void Urunekle()
        {
            var list2 = Oku();
            var d = list2.FirstOrDefault(s => s.Urunadi == Urunadi);
            if (d != null)
            {
                d.UrunSayisi += UrunSayisi;
            }
            else
            {
                list2.Add(this);
            }
            Yaz(list2);

        }



    }
}
