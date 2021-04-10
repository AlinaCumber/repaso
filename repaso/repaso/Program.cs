using System;

namespace repaso
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //ejercicio 15 


            int[] arab =
            {
                1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000, 1400, 1500, 1900, 2000, 2400, 2500, 2900, 3000,
                3400, 3500, 3900, 4000, 5000, 6000, 7000, 8000, 9000, 10000, 20000, 30000, 40000, 50000, 60000, 70000,
                80000, 90000,
                100000, 200000, 300000, 400000, 500000, 600000, 700000, 800000, 900000, 1000000, 2000000, 3000000,
                3999999
            };

            string[] rim =
            {
                "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M", "MCD", "MD", "MCM", "MM", "MMCD",
                "MMD", "MMCM", "MMM", "MMMCD", "MMMD", "MMMCM", "I'V'", "V'", "V'I'", "V'II", "V'III", "I'X'", "X'",
                "X'X'",
                "X'X'X'", "X'L'", "L'", "L'X'", "LX'X'", "LX'X'X'", "C'X'", "C'", "C'C'", "C'C'C'", "C'D'", "D'",
                "D'C'", "D'C'C'",
                "D'C'C'C'",
                "C'M'", "M'", "M'M'", "M'M'M'", "X'X'X'I'X'CMXCIX"
            };

            Console.WriteLine("Introduce numero para convertir a numero romano hasta 3999999");
            int user = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            string result = "";

            while (user > 0)

            {
                if (arab[i] == user)
                {
                    user = user - arab[i];
                    result = result + rim[i];
                }
                else if (arab[i] > user)
                {
                    user = user - arab[i - 1];
                    result = result + rim[i - 1];

                    if (arab[i] == 1)
                    {
                        result = result + rim[0];
                        user = user - 1;
                    }

                    i = 0;
                }


                else
                    i++;
            }

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("El resultado es {0}", result);
        }
    }
}