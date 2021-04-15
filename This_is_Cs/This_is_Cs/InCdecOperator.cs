using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class InCdecOperator
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a++);
            Console.WriteLine(++a);

            Console.WriteLine(a--);
            Console.WriteLine(--a);
        }
    }
}

// 결과값
// 10
// 12
// 12
// 10

// Increment Operator 증가 연산자
// Decrement Operator 감소 연산자