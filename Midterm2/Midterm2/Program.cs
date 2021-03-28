using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input A : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input B : ");
            int b = int.Parse(Console.ReadLine());
            int x = a;
            int y = b;

            while (x != y)
            {
                if (x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }

            }
            Console.WriteLine("LCM of "+ a +" and "+ b +" is "+ x);
            Console.ReadLine();
        }
    }
}
