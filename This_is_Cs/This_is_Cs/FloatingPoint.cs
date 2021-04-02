using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class FloatingPoint
    {
        static void Main(string[] args)
        {
            float a = 3.1415_9265_3589_7932_3846f;
            Console.WriteLine(a);

            double b = 3.1415_9265_3589_7932_3846;
            Console.WriteLine(b);
        }
    }
}

// 결과값
// 3.141593
// 3.14159265358979

// float는 단일 정밀도 부동 소수점 형식 (7개의 자릿수만 다룰수 있음) 4비트(32비트)
// double은 복수 정밀도 부동 소수점 형식 (15~16개의 자릿수를 다룰 수 있음) 8비트(64비트)