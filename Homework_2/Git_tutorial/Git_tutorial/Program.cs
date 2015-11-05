using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x: ");
            string x = Console.ReadLine();
            Console.WriteLine("Enter y: ");
            string y = Console.ReadLine();

            int int_x = int.Parse(x);
            int int_y = int.Parse(y);

            for (int i = 0; i < (int_x + int_y); i++)
            {
                Console.WriteLine(i+1 + ") *");
            }

                Console.ReadLine();
        }
    }
}
