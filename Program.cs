using System;

namespace if_state
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if(time>= 6 && time<= 11)
            {
                Console.WriteLine("Günaydın!");
            }
            else if(time <= 18)
            {
                Console.WriteLine("İyi günler!");
            }
            else
            {
                Console.WriteLine("İyi geceler");
            
            }
            string sonuç = time >=6 && time <= 11 ? "Günaydın" : time <= 18 ? "İyi günler!" : "İyi geceler!";
            Console.WriteLine(sonuç);

            Console.ReadKey();

        }
    }
}
