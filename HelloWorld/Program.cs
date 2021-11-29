using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            


        }
        static void TekMiÇiftMi()
        {
            while (true)
            {
                Console.WriteLine("Bir sayı giriniz");
                double s;
                s = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Bir sayı giriniz");
                double d;
                d = Convert.ToDouble(Console.ReadLine());
                double x = 17, y = 18;
                double a;
                Console.WriteLine("Hello World!");
                a = x / y;
                double c = s + d;
                if (c % 2 == 0)
                {
                    Console.WriteLine(c + "selam");
                    break;
                }
                else Console.WriteLine(c + "Tek sayıdır");

            }
        }
        
    }
}
