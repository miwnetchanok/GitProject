using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            Console.WriteLine("Item in box 1 : ");
            int box1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Item in box 2 : ");
            int box2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Item in box 3 : ");
            int box3 = int.Parse(Console.ReadLine());

            while (box1 > 0 || box2 > 0 || box3 > 0)
            {
                if (n == 1)
                {
                    Console.WriteLine("Player A");
                }
                else
                {
                    Console.WriteLine("Player B");
                }
                Console.WriteLine("Choose box : ");
                int Box = int.Parse(Console.ReadLine());
                Console.WriteLine("Number of Pickup : ");
                int NumberOfPickup = int.Parse(Console.ReadLine());
                if (Box == 1)
                {
                    box1 = box1 - NumberOfPickup;
                    n = n * -1;
                    Console.WriteLine("box 1 : {0} ", box1);
                }
                else if (Box == 2)
                {
                    box2 = box2 - NumberOfPickup;
                    n = n * -1;
                    Console.WriteLine("box 2 : {0} ", box2);
                }
                else if (Box == 3)
                {
                    box3 = box3 - NumberOfPickup;
                    n = n * -1;
                    Console.WriteLine("box 2 : {0} ", box3);
                }
            }
            if (n == 1)
            {
                Console.WriteLine("Player A Win");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Player B Win");
                Console.ReadLine();
            }

        }
    }
}
