using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace This_is_Cs
{
    class StringInterpolation
    {
        static void Main(string[] args)
        {
            string name = "김튼튼";
            int age = 23;
            WriteLine($"{name, -10}, {age:D3}");

            name = "박날씬";
            age = 30;
            WriteLine($"{name}, {age,-10:D3}");

            name = "이비실";
            age = 17;
            WriteLine($"{name}, {(age > 20 ? "성인" : "미성년자")}");
        }
    }
}

// 결과값
// 김튼튼    , 023
// 박날씬, 030
// 이비실, 미성년자

// Format() 메소드와 더불어 서식화된 문자을 편리하게 다룰 보간(Interpolation)이 있습니다.