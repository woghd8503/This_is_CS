using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class IfElse
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요. : ");

            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number < 0)
                Console.WriteLine("음수");
            else if (number > 0)
                Console.WriteLine("양수");
            else
                Console.WriteLine("0");

            if (number % 2 == 0)
                Console.WriteLine("짝수");
            else
                Console.WriteLine("홀수");
        }
    }
}
// 결과값
// 숫자를 입력하세요 : 33
// 양수
// 홀수

// 결과값 1
// 숫자를 입력하세요 : -12
// 음수 
// 짝수