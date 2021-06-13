using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bermtable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            int n;
            bool Finish = false;
            Console.WriteLine("Add Your Number");

            for (int i = 0; i < 9;)
            {
                Console.Write("Number ");
                if (int.TryParse(Console.ReadLine(), out n) && i < 9)
                {
                    num.Add(n);
                    Console.WriteLine();
                    i++;
                }
            }

            if (num.Count == 9)
            {
                DrawTable();
                Console.WriteLine();
                Console.Write("New Num: ");
            }

            if (int.TryParse(Console.ReadLine(), out n))
            {
                FindZero(n);
                DrawTable();
            }

            void FindZero(int newNumber)
            {
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i] == 0)
                    {
                        num[i] = newNumber;
                    }
                }
            }


            void DrawTable()
            {
                for (int i = 0; i < num.Count;)
                {
                    for (int j = 0; j < 3; j++)//แถว
                    {
                        for (int k = 0; k < 3; k++)//หลัก
                        {
                            Console.Write(num[i]);
                            i++;
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
