using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class Test2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test1");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.WriteLine("\ntest2");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("\ntest3");
            int e = 0;
            do
            {
                e++;
                int j = 0;
                while (j < e)
                {
                    j++;
                    Console.Write('*');
                }
                Console.WriteLine();
            } while (e < 5);

            Console.WriteLine();
            int n = 0;
            do
            {
                int k = 5;
                while (k > n)
                {
                    k--;
                    Console.Write('*');
                }
                Console.WriteLine();
                n++;
            } while (n < 5);

            Console.WriteLine("\nTest4");
            
        }
    }
}
