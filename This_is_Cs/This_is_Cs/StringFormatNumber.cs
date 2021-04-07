using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace This_is_Cs
{
    class StringFormatNumber
    {
        static void Main(string[] args)
        {
            // D : 10진수
            WriteLine("10진수: {0:D}", 123); // WriteLine(string.Format) ("10진수: {0:D}", 123))과 동일
            WriteLine("10진수: {0:D5}", 123);

            // X : 16진수
            WriteLine("16진수: 0x{0:X}", 0xFF1234);
            WriteLine("16진수: 0x{0:X8}", 0xFF1234);

            // N : 숫자
            WriteLine("숫자: {0:N}", 123456789);
            WriteLine("숫자: {0:N0}", 123456789); // 자릿수 0은 소숫점 이하를 제거함.

            // F : 고정소수점
            WriteLine("고정소수점: {0:F}", 123.45);
            WriteLine("고정소수점: {0:F5}", 123.45);

            // E : 공학용
            WriteLine("공학: {0:E}", 123.456789);
        }
    }
}

// 결과값
// 10진수: 123
// 10진수: 00123
// 16진수: 0xFF1234
// 16진수: 0x00FF1234
// 숫자: 123,456, 789.00
// 숫자: 123,456, 789
// 고정소수점: 123.45
// 고정소수점: 123.456000
// 공학: 1.234568E+002

// 서식 지정자 D / 10진수 / 입력된 수를 10진수로 서식화합니다.
// 서식 지정자 X / 16진수 / 입력된 수를 16진수로 서식화합니다.
// 서식 지정자 N / 콤마(,)를 묶어 표현한 수 / 입력된 수를 콤마로 구분하여 출력합니다.
// 서식 지정자 F / 고정소수점 / 입력된 수를 고정소수점 형식으로 서식화합니다. 
// 서식 지정자 E / 지수 / 입력된 수를 지수 표기로 서식화합니다.
