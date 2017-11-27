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
            Console.WriteLine("Witaj " + name);
            GreetUsr();
        }
        public static void GreetUsr()
        {
            Console.WriteLine("Ile razy mam powtórzyć twoje imię?");
            string num = Console.ReadLine();
            int i = 0;
            try
            {
                i = Convert.ToInt32(num);
            }
            catch
            {
                Console.WriteLine("Wpisz ponownie liczbę powtórzeń: ");
                num = Console.ReadLine();
                i = Convert.ToInt32(num);
            }
            // Tu ma być pętelka która wyświetla i razy imię
            for(int x=0;x == i; x++)
            {
                
            }
        }
    }
}
