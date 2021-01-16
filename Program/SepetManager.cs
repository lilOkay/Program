using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class SepetManager
    {
       public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler .Sepete Eklendi! : " +urun.Adi);
        }
        public void Ekle2(string urunadi,string aciklama, double fiyati, int StockAdedi)
        {
            Console.WriteLine("Tebrikler sepete eklendi! : " + urunadi);
        }
    }
}
