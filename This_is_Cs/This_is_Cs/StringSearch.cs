using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace This_is_Cs
{
    class StringSearch
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

            // IndexOf()
            WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));

            // LastIndexOf()
            WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
            WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf("o"));

            // StartsWith()
            WriteLine("StartWith 'Goood' : {0}", greeting.StartsWith("Good"));
            WriteLine("StartWith 'Morning' : {0}", greeting.StartsWith("Morning"));

            // EndsWith()
            WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
            WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));

            // Contains()
            WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
            WriteLine("Contains 'Evening' : {0}", greeting.Contains("Morning"));

            // Replace()
            WriteLine("Replaced 'Morning' with 'Evening': {0}", greeting.Replace("Morning", "Evening"));
        }
    }
}

// 결과 값 
// IndexOf 'Good' : 0
// IndexOf 'o' : 1
// LastIndexOf 'Good' : 0
// LastIndexOf '0' : 6
// StartsWith 'Good' : True
// StartsWith 'Morning' : False
// EndsWith 'Good' : False
// EndsWith 'Morning' : True
// Contains 'Evening' : False
// Contains 'Morning' : True
// Replaced 'Morning' with 'Evening': Good Evening

// IndexOf() : 현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 찾습니다.
// LastIndexOf() : 현재 문자열 내에서 찾고자 하는 지정된 문자열의 위치를 뒤에서부터 찾습니다.
// StartsWith() : 현재 문자열이 지정된 문자열로 시작하는지를 평가합니다.
// EndsWith() : 현재 문자열이 지정된 문자열로 끝나는지를 평가합니다.
// Contains() : 현재 문자열이 지정된 문자열을 포함하는지를 평가합니다.
// Replace() : 현재 문자열에서 지정된 문자열이 다른 지정된 문자열로 무두 바뀐 새 문자열을 반환합니다.


