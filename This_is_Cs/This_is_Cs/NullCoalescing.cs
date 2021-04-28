using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class NullCoalescing
    {
        static void Main(string[] args)
        {
            int? num = null;
            Console.WriteLine($"{num ?? 0}");

            num = 99;
            Console.WriteLine($"{num ?? 0}");

            string str = null;
            Console.WriteLine($"{str ?? "Default"}");

            str = "Specific";
            Console.WriteLine($"{str ?? "Default"}");
        }
    }
}
// 결과값
// 0
// 99
// Default
// Specific

// Null병합 연산자 ??는 Null 조건부 연산자처럼 프로그램에서 종종
// 필요한 변수/객체의 null 검사를 간결하게 만들어주는 역할