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
            do
            {
                Console.WriteLine("숫자를 입력하세요 / 종료를 원하시면 00을 입력하세요");
                string input = Console.ReadLine();
                int testNum = Convert.ToInt32(input);
                Console.Write("testNum:{0}\n", testNum);
                if (testNum > 0)
                {
                    for (int i = 0; i < testNum; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                else Console.WriteLine("0보다 작거나 같은 숫자는 입력할 수 없습니다.");

                if (testNum == 00) break;
            } while (true);
        }
    }
}
