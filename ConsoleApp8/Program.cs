using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            string holder;
            int number = 0;

            while (number != 3)
            {
                Console.WriteLine("enter 3 or else!");
                holder = Console.ReadLine();
                number = Convert.ToInt32(holder);
            }

            do
            {
                Console.WriteLine("enter 20 or else!");
                holder = Console.ReadLine();
                number = Convert.ToInt32(holder);
            } while (number != 20);

            Console.ReadLine();


        }
    }
}
