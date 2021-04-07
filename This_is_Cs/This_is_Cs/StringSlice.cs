using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace This_is_Cs
{
    class StringSlice
    {
        static void Main(string[] args)
        {
            string greeting = "Good morning.";

            WriteLine(greeting.Substring(0, 5)); // "Good"
            WriteLine(greeting.Substring(5)); // "morning"
            WriteLine();

            string[] arr = greeting.Split(new string[] {" "}, StringSplitOptions.None);
            WriteLine("World Count : {0}", arr.Length);

            foreach (string element in arr)
                WriteLine("{0}", element);
        }
    }
}
// 결과 값
// Good
// Morning.
//
// World Count : 2
// Good
// morning.

// Split() : 현재 문자열을 지정된 문자를 기준으로 분리한 문자열의 배열을 반환합니다.
// SubString() : 현재 문자열의 지정된 위치로부터 지정된 수만큼의 문자로 이루어진 새 문자욜을 반환합니다.
