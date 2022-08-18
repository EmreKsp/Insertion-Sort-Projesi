using System;

namespace neden
{
    class Program
    {
        

        static void Main(string[] args)
        {

        int x = 3;
        int y = 3;
        y = y+2;
        Console.WriteLine(y);
        y += 2;
        Console.WriteLine(y);
        y /= 1;
        Console.WriteLine(y);
        x *= 2;
        Console.WriteLine(x);

        //mantıksal operatorler
        // || && !
        bool isSucces= true;
        bool isCompleted = false;
        if(isSucces && isCompleted)
        Console.WriteLine("Perfect!");
        if(isSucces || isCompleted)
        Console.WriteLine("Great");
        if(isSucces && !isCompleted)
        Console.WriteLine("Whatever!");
        //ilişkise operatorler
        // < > ==  <= >=   !=
        int a = 3;
        int b =4;
        bool sonuç = a<b;
        Console.WriteLine(sonuç);
        sonuç = a>b;
        Console.WriteLine(sonuç);
        sonuç = a<=b;
        Console.WriteLine(sonuç);
        sonuç = a>=b;
        Console.WriteLine(sonuç);
        sonuç = a!=b;
        Console.WriteLine(sonuç);
        sonuç= a==b;
        Console.WriteLine(sonuç);
        //Aritmetik operatorler + - * / 
        int sayı1 = 10;
        int sayı2 = 5;
        int sonuç1 = sayı1 / sayı2;
        Console.WriteLine(sonuç1);
        sonuç1 = sayı1* sayı2;
        Console.WriteLine(sonuç1);
        sonuç1 = sayı1 + sayı2;
        Console.WriteLine(sonuç1);
        sonuç1 = sayı1++ ;
        Console.WriteLine(sonuç1);
        //% mod(kalan) alır
        int sonuç2 = 20%3;
        Console.WriteLine(sonuç2);




        Console.ReadKey();
       //https:app.patika.dev/exthia
        }    
    }
}