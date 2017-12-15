using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jak się nazywasz?");
            string name = Console.ReadLine();
            Console.WriteLine("Ile razy wyświetlić?");
            int num = Convert.ToInt32(Console.ReadLine());
            GreetUsr(name, num);
            Console.ReadKey();
        }
        public static void GreetUsr(string imie, int time)
        {
            int i = time;
            try
            {
                i = Convert.ToInt32(i);
            }
            catch
            {
                Console.WriteLine("Wpisz ponownie liczbę powtórzeń: ");
                string num = Console.ReadLine();
                i = Convert.ToInt32(num);
            }
            for (int x = 0; x <= i; x++)
            {
                Console.WriteLine("Witaj " + imie);
            }
        }
    }
}
