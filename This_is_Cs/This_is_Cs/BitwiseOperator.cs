using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class BitwiseOperator
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 10;

            Console.WriteLine($"{a} & {b} : {a & b}");
            Console.WriteLine($"{a} | {b} : {a | b}");
            Console.WriteLine($"{a} ^ {b} : {a ^ b}");

            int c = 255;
            Console.WriteLine("~{0}(0x{0:X8}) : {1}(0x{1:X8})", c, ~c);
        }
    }
}
// 결과값
// 9 & 10 : 8
// 9 | 10 : 11
// 9 ^ 10 : 3
// ~255(0x0000FF) : -256(0xFFFFFF00)
