using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int stMetov = 0;
            Random rnd = new Random();
            int[] meti = new int[6];
            try
            {
                Console.Write("Vnesi število metov kocke: ");
                stMetov = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception e)
            {
                if (e.Message == "Input string was not in a correct format.")
                {
                    Console.WriteLine("Vnašaš neumnosti !!!");
                }
                Console.ReadKey();
                Environment.Exit(0);
            }
            for (int i = 1; i <= stMetov; i++)
            {
                int met = rnd.Next(1,7);
                meti[met - 1] = meti[met - 1] + 1;
            }
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("Število vrednosti {0}= {1} {2}%", i, meti[i - 1], ((float)meti[i - 1] / stMetov) * 100);
            }
            Console.ReadKey();
        }
    }
}
