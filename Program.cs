using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, k, sum;
            Console.WriteLine("Enter n1");
            n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter n2");
            n2 = Int32.Parse(Console.ReadLine());
            for (int i = n1; i <= n2; i++)
            {

                sum = 0;
                for (k = 1; k < i; k++)
                {
                    if (i % k == 0)

                        sum = sum + k;

                }
                if (sum == i)
                    Console.WriteLine(i);

            }
        }
    }
    
}
