using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeProblems
{
    internal class Pattern
    {
        public void Pttrn()
        {
            int i, j, k;
            Console.WriteLine("Enter the number");
            k = int.Parse(Console.ReadLine());
            

            for (i = 1; i <= k; i++)
            {
                for (j = k; j>i; j--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (j = i - 1; j >= 1; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine("\n");
            }
        }
    }
}
