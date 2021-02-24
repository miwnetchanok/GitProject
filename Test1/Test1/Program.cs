using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCode;
            string inputAgency;

            int mainUnit, tensDigit, hundredDigit, thousands, tenThousands, hundredThousands;

            bool isCorrect = false; 

            Console.Write("Please input code: ");
            inputCode = Console.ReadLine();
            Console.Write("Please input Agency: ");
            inputAgency = Console.ReadLine();

            mainUnit = Convert.ToInt32(char.GetNumericValue(inputCode[5]));
            tensDigit = Convert.ToInt32(char.GetNumericValue(inputCode[4]));
            hundredDigit = Convert.ToInt32(char.GetNumericValue(inputCode[3]));
            thousands = Convert.ToInt32(char.GetNumericValue(inputCode[2]));
            tenThousands = Convert.ToInt32(char.GetNumericValue(inputCode[1]));
            hundredThousands = Convert.ToInt32(char.GetNumericValue(inputCode[0]));

            if (inputAgency == "CIA")
            {
                if (mainUnit % 3 == 0)
                {
                    if (tensDigit != 1 && tensDigit != 3 && tensDigit != 5)
                    {
                        if (thousands >= 6 && thousands != 8)
                        {
                            isCorrect = true;
                        }
                    }
                }

            }
            else if (inputAgency == "FBI")
            {
                if (4 <= hundredThousands || hundredThousands <= 7)
                {
                    if (hundredDigit % 2 == 0 && hundredDigit != 6)
                    {
                        if (tenThousands % 2 != 0)
                        {
                            isCorrect = true;
                        }
                    }
                }
            }
            else if (inputAgency == "NSA")
            {
                if (30 % mainUnit == 0)
                {
                    if (hundredDigit % 3 == 0 && hundredDigit % 2 != 0)
                    {
                        for (int i = 0; i < inputCode.Length; i++)
                        {
                            if (inputCode[i] == '7')
                            {
                                isCorrect = true;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(isCorrect.ToString());
            Console.ReadLine();
        }
    }
}