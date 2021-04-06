using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace This_is_Cs
{
    class StringMotify
    {
        static void Main(string[] args)
        {
            WriteLine("ToLower() : '{0}'", "ABC".ToLower());
            WriteLine("ToUpper() : '{0}'", "abc".ToUpper());

            WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny"));
            WriteLine("Remove() : '{0}'", "I Don't Love You.".Remove(2, 6));

            WriteLine("Trim() : '{0}'", " No Spaces ".Trim());
            WriteLine("TrimStart() : '{0}'", " No Space ".TrimStart());
            WriteLine("TrimEnd() : '{0}'", " No Space ".TrimEnd());
        }
    }
}

// 결과 값
// Lower() : 'abc'
// ToUpper() : 'ABC'
// Insert() : 'Happy Sunny Friday!'
// Remove() : 'I Love You.'
// Trim() : 'No Spaces'
// TrimStart() : 'No Spaces '
// TrimEnd() : ' No Spaces'

// ToLower() : 현재 문자열의 모든 대문자를 소문자로 바꾼 새 문자열을 반환합니다.
// ToUpper() : 현재 문자열의 모든 소문자를 대문자로 바꾼 새 문자열을 반환합니다.
// Insert() : 현재 문자열의 지정된 위치에 지정된 문자열이 삽입된 새 문자열을 반환합니다.
// Remove() : 현재 문자열의 지정된 위치로부터 지정된 수만큼의 문자가 삭제된 새 문자열을 반환합니다.
// Trim() : 현재 문자열의 앞/뒤에 있는 공백을 삭제한 새 문자열을 반환합니다.
// TrimStart() : 현재 문자열의 앞에 있는 공백을 삭제한 새 문자열을 반환합니다.
// TrimEnd() : 현재 문자열의 뒤에 있는 공백을 삭제한 새 문자열을 반환합니다.
