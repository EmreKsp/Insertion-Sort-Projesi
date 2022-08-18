using System;

namespace hata_yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayı = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("girmiş olduğunuz sayı: " +sayı);
//
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("hata: " + ex.Message.ToString());
            //    
            //}
            //finally
            //{
            //    Console.WriteLine("İşlem tamamlandı");
//
            //}
            try
            {
               // int a = int.Parse(null);
               // int a = int.Parse("test");
                int a = int.Parse(-200000000000);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
                
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük veya çok büyük değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("işlem tamamlandı");
            }
            Console.ReadKey();
        }
    }
}
