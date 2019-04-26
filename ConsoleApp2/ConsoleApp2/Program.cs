using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrike
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrola = true;
            int prvo, drugo;
            Console.WriteLine("Program izračuna tablico množenja v podanem obsegu");
            Console.WriteLine("Vnesemo mu 2 števili na intervalu od nič do 100");
            Console.WriteLine("Števili se ne smeta razlikovati za več kot 20");
            do
            {
                Console.Write("\nVnesi prvo število: ");
                prvo = int.Parse(Console.ReadLine());
                Console.Write("\nVnesi drugo število: ");
                drugo = int.Parse(Console.ReadLine());
                if (Math.Abs(prvo - drugo) <= 20 && (prvo > 0 && prvo <= 100) && (drugo > 0 && drugo <= 100))
                {
                    kontrola = false;
                }
                else
                {
                    Console.WriteLine("\nŠtevili nista primerni. ");
                }
            } while (kontrola);
            if (prvo > drugo) // zamenjamo vrednosti spremenljivk
            {
                int temp = drugo;
                drugo = prvo;
                prvo = temp;
            }
            int velikost = drugo - prvo + 1;
            double[,] tabela = new double[velikost, velikost];
            Console.Write("   ");
            for (int i = prvo; i <= drugo; i++)
            {
                Console.Write("{0,5}", i);
            }
            Console.WriteLine();
            for (int i = 0; i < velikost; i++)
            {
                Console.Write("{0,3}", prvo + i);
                for (int j = 0; j < velikost; j++)
                {
                    tabela[i, j] = (prvo + i) * (prvo + j);
                    Console.Write("{0,5}", tabela[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("   ");
            for (int i = drugo; i >= prvo; i--)
            {
                Console.Write("{0,5}", i);
            }
            Console.WriteLine();
            for (int i = velikost; i > 0; i--)
            {
                //Console.Write("{0,3}", drugo - velikost + i);
                Console.Write("{0,3}", prvo + i - 1);
                for (int j = velikost; j > 0; j--)
                {
                    Console.Write("{0,5}", tabela[i - 1, j - 1]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
