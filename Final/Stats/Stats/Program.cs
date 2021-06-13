using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            double Max = 0;
            double Min = 0;
            double Sum = 0;
            bool stop = false;
            bool ShowResult = false;
            while (!stop)
            {
                var Input = Console.ReadLine();
                if (Input == "End")
                {
                    stop = true;
                }
                else
                {
                    double n = double.Parse(Input);
                    if (size == 0)
                    {
                        Max = n;
                        Min = n;
                    }
                    else if (Max < n)
                    {
                        Max = n;
                    }
                    else if (Min > n)
                    {
                        Min = n;
                    }
                    Sum += n;
                    size++;
                }
            }

            while (!ShowResult)
            {
                var InputMethod = Console.ReadLine();
                if (InputMethod == "FindMax")
                {
                    Console.WriteLine(Max);
                    ShowResult = true;
                }
                else if (InputMethod == "FindMin")
                {
                    Console.WriteLine(Min);
                    ShowResult = true;
                }
                else if (InputMethod == "FindMean")
                {
                    Console.WriteLine(Sum / size);
                    ShowResult = true;
                }
                else
                {
                    Console.WriteLine("Invalid Mode");
                }
            }
            Console.ReadLine();
        }
    }
}
