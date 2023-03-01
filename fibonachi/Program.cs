using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            Console.Write("Колко числа да генерира ? - ");
            byte n = byte.Parse(Console.ReadLine()); 

            List<long> num = new List<long>();
            num.Add(1);
            num.Add(1);

            for (int i = 2; i < n; i++)
            {
                num.Add(num[i - 2] + num[i - 1]);
            }

            // OUTPUT

            Console.WriteLine(string.Join(", ", num));
        }
    }
}
