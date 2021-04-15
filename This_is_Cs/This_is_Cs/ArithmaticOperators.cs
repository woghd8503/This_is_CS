using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class ArithmaticOperators
    {
        static void Main(string[] args)
        {
            int a = 111 + 222;
            Console.WriteLine($"a : {a}");

            int b = a - 100;
            Console.WriteLine($"b : {b}");

            int c = b * 10;
            Console.WriteLine($"c : {c}");

            double d = c / 6.3;
            Console.WriteLine($"d : {d}");

            Console.WriteLine($"22 / 7 = {22 / 7}({22 % 7})"); // % 왼쪽 연산자를 오른쪽 피연산사로 나눈 후의 나마지 값
        }
    }
}

// 결과값
// a : 333
// b : 233
// c : 2330
// d : 369.84126984127
// 22 / 7 = 3(1)

// 연산자 우선순위 *부터 시작 3 + 4 * 5 = 35