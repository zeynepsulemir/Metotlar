using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun(); //Class tanımlama (Class'ın örneği)
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması..";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati =80;
            urun2.Aciklama = "Diyarbakır karpuzu..";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler) //Ürün sayısı kadar döner. Urun-veri tipi, urun-anlık takma isim, urunler-dizi 
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------------------");
                
            }


            //instance -Class örneği oluşturma

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            
            
            
            
            
            Console.ReadKey();
        }
    }
}
