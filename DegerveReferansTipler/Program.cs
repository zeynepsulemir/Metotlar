using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            //30 yazar. int, double, decimal, float, bool= DEĞER TİP       0-1
            //bellekte STACK - değer tipler burada gerçekleşir.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300};
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // 999 yazar. array, class, interface = REFERANS TİP
            //bellek HEAP - referans tipler burada gerçekleşir.
            // sayilar1 de iken Stack de new dediğim anda sayilar1 için yeni bir alan oluşturuyor. Heap' e geçiyor. 
            //new- bellekten bir adres oluştur.. 


        }
    }
}
