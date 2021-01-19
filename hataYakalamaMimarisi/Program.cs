using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hataYakalamaMimarisi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region try catch

            //try
            //{
            //    Console.WriteLine("bir sayı giriniz");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("bir sayı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine("bir hata oluştu.");
            //}

            #endregion

            #region try catch exception

            //try
            //{
            //    Console.WriteLine("bir sayı giriniz");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("bir sayı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("bir hata oluştu.\n" + ex.Message);
            //}

            #endregion

            #region hata yakalama mimarisi

            //try
            //{
            //    Console.WriteLine("bir sayı giriniz");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("bir sayı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi1 / sayi2;
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("Format hatası oluştu");
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("0'a bölme hatası");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("bir hata oluştu.\n" + ex.Message);
            //}

            #endregion

            #region try catch finally

            //try
            //{
            //    Console.WriteLine("bir sayı giriniz");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("bir sayı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int bolum = sayi1 / sayi2;
            //    Console.WriteLine("sonuç: "+bolum);
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("format hatası");
            //}
            //finally
            //{
            //    //her durumda çalışır
            //    //yakalanamayan bir hata bile oluşsa çalışır.
            //    Console.WriteLine("finally çalıştı");
            //}
            //Console.WriteLine("hata alanı dışı");

            #endregion

        }
    }
}
