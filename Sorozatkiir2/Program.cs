using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorozatkiir2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. feladat
            for (int i = 1; i < 11; i++)
            {
                Console.Write(i + ", ");
            }

            //3. feladat


            bool igaz = false;
            while (igaz == false)
            {
                Console.Write("\nKérek egy 1-től nagyobb számot 10-ig maximum: ");
                int kezdes = Convert.ToInt32(Console.ReadLine());
                if (kezdes < 1)
                {
                    Console.WriteLine("\nHibás megadás! 1-nél nagyobb számot adjon meg!");
                }
                else if (kezdes > 10)
                {
                    Console.WriteLine("\nHibás megadás! 10-nél kisebb számot adjon meg!");
                }
                else
                {
                    igaz = true;
                    for (int i = kezdes; i <= 10; i++)
                    {

                        Console.Write(i + ", ");

                    }
                }
            }

            //4. feladat

            bool  talalat = false;
            while (!talalat)
            {
                Console.Write("\nKérek egy kezdő számot: ");
                int kezdes = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nKérek egy Végszámot: ");
                int veg = Convert.ToInt32(Console.ReadLine());

                if (talalat = kezdes < veg || veg > kezdes)
                {

                    for (int i = kezdes; i <= veg; i++)
                    {
                        Console.Write(i + ", ");
                    }
                    
                }

                else
                {
                    Console.WriteLine("Rossz megadás!");

                }

            }

            Console.ReadKey();
        }
    }
}
