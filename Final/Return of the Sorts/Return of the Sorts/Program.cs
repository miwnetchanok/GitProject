using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_of_the_Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] num = new int[size];
            int[] originalnum = new int[size];
            for (int i = 0; i < size; i++)
            {
                int a = int.Parse(Console.ReadLine());
                num[i] = a;
                originalnum[i] = a;
            }
            Array.Sort(num);

            Console.Write("Normal Sort ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Backward Sort ");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Original Sort ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(originalnum[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Backward Original Sort ");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(originalnum[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
