using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1;
            int sayi2;
            string islem;
            int sonuc = 0;
            
            Console.WriteLine("****** Hesap Makinesi ******");
            Console.WriteLine("Çarpma (*) - Toplama (+) - Çıkarma (-) - Bölme (/)");
            Console.Write("Yapmak istediğiniz işlem: ");
            islem = Convert.ToString(Console.ReadLine());
            Console.Write("1. Sayı: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayı: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            

            if (islem == "*")
            {
                Console.Write(sayi1 + " * " + sayi2 + " = Sonuç: " + carpMethod(sayi1,sayi2));

            }

            if (islem == "+")
            {
                Console.Write(sayi1 + " + " + sayi2 + " = Sonuç: " + toplaMethod(sayi1, sayi2));
            }

            if (islem == "-")
            {
                Console.Write(sayi1 + " - " + sayi2 + " = Sonuç: " + cikarMethod(sayi1, sayi2));
            }

            if (islem == "/")
            {
                Console.Write(sayi1 + " / " + sayi2 + " = Sonuç: " + bolMethod(sayi1, sayi2));
            }


            



            Console.ReadLine();
        }

        static int carpMethod(int s1, int s2)
        {
            int result = s1 * s2;
            return result;
        }

        static int toplaMethod(int s1, int s2)
        {
            int result = s1 + s2;
            return result;
        }

        static int cikarMethod(int s1, int s2)
        {
            int result = s1 - s2;
            return result;
        }

        static int bolMethod(int s1, int s2)
        {
            int result = s1 / s2;
            return result;
        }
    }
}
