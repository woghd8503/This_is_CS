using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class IntegralConversion
    {
        static void Main(string[] args)
        {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128; // sbyte의 최대값 127보다 1 큰 수
            Console.WriteLine(x);

            sbyte y = (sbyte)x;  // 오버플로우가 발생
            Console.WriteLine(y);
        }
    }
}

// 결과 값
// 127
// 127
// 128
// -128

// 데이터 형식 바꾸기 Type Conversion
// 크기(표현 범위)가 서로 다른 정수 형식 사이의 변환
// 크기(표현 범위)가 서로 다른 부동 소수점 형식 사이의 변환
// 부호 있는 정수 형식과 부호 없는 정수 형식 사이의 변환
// 부동 소수점 형식과 정수 형식 사이의 변환
// 문자열과 숫자 사이의 변환
