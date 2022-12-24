using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_if_number_is_perfect
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("write the first number : ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("write the second number :");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("the perfect numbers : ");
            for (; f <= s; f++)
            {
                int sum = 0;

                for (int n = 1; n < f; n++)
                {
                    if (f % n == 0)
                    {

                        sum += n;
                  
                    }
                   
                }
                if (sum == f)
                {
                    Console.WriteLine(f);
                }
            }
            Console.ReadKey();
        }
    }
}
