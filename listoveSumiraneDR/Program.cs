using System;
using System.Collections.Generic;

namespace listoveSumiraneDR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT

            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            // OUTPUT

            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int Reverse = 0;
                while (list[i] > 0)
                {
                    int remainder = list[i] % 10;
                    Reverse = (Reverse * 10) + remainder;
                    list[i] = list[i] / 10;
                }
                sum = sum + Reverse;
            }

            Console.WriteLine($"Sum: {sum}");

        }
    }
}
