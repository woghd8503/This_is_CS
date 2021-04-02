using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class Constant
    {
        static void Main(string[] agrs)
        {
            const int MAX_INT = 214783647;
            const int MIN_INT = -2147483648;

            Console.WriteLine(MAX_INT);
            Console.WriteLine(MIN_INT);
        }
    }
}

// 결과 값
// 2147483647
// -2147483648

// 상수 Constants와 열거 형식 Enumerator은 변수와 달리 안에 담긴 데이터를 절대 바꿀 수 없는
// 메모리 공간입니다.