using System;

namespace tip_dönüşümleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit (bilinçsiz)  dönüşüm
            byte a = 5;
            sbyte b = 10;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d:" + d);
            long h = d;
            Console.WriteLine("h:" + h);
            float i = h;
            Console.WriteLine("i:" + i);
            string e = "zikriye";
            char f = 'k';
            object g = e+f+d;
            Console.WriteLine("g:" + g);
            //Explicit(bilinçli) dönüşüm
            byte x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);
            int z = 100;
            byte t =(byte)z;
            Console.WriteLine("t:" + t);

            float w =10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);
            // ToString metodu
            int xx = 6;
            string yy= xx.ToString();
            Console.WriteLine("yy" +xx);
            string zz = 12.5.ToString();
            Console.WriteLine("zz:" + zz);
            //System.Convert
            string s1 = "10" , s2="20";
            int sayı1, sayı2;
            int toplam;
            sayı1 = Convert.ToInt32(s1);
            sayı2 = Convert.ToInt32(s2);
            toplam = sayı1 + sayı2;
            Console.WriteLine(toplam);
            //Parse (sadece string alır ve string dönüştürür)
            ParseMethod();


            Console.ReadKey();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.2";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            Console.WriteLine(rakam1);
            double1 = Double.Parse(metin2);
            Console.WriteLine(metin2);




        }
    }
}
