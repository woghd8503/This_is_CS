using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace This_is_Cs
{
    class NullConditionalOperator
    {
        static void Main(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구"); // a?.이 null을 반환하므로 Add() 메소드는 호출되지 않음
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}"); // a?.이 null을 반환하므로 Add() 메소드는 호출되지 않음
            WriteLine($"{a ?[0]}");
            WriteLine($"{a ?[1]}");

            a = new ArrayList(); // a는 이제 더 이상 null이 아닙니다.
            a?.Add("야구");
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");
        }
    }
    // 결과값
    // Count :
    //
    //
    // Count : 2
    // 야구
    // 축구

}
