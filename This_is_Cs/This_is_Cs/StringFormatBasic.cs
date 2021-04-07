using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace This_is_Cs
{
    class StringFormatBasic
    {
        static void Main(string[] args)
        {
            string fmt = "{0,-20}{1,-15}{2, 30}";

            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Hanbit", "Sanghyun Park", "C# 7.0 Programming");
            WriteLine(fmt, "Practice Hall", "K&R", "The C Programming Language");
        }
    }
}

// 결과 값
// Publisher           Author                                  Title
// Marvel              Stan Lee                             Iron Man
// Hanbit              Sanghyn Park               C# 7.0 Programming
// Practice Hall       K&R                The C Programming Language

// C# 문자열 서식화 2가지 방법 중 첫번째 
// 1. string 형식의 Format() 메서드: 
//      ConSole.WriteLine("제목 : {0}", "이것이 C#이다.") -20 오른쪽 20 왼쪽에서 시작
//      Console.WriteLine("Total : {0, -7, D}", 123); // 첨자:0, 맞춤:-7, 서식 문자열:D 

  