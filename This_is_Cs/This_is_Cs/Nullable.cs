using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class Nullable
    {
        static void Main(string[] args)
        {
            int? a = null;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);

            a = 3;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);
        }
    }
}

// 결과 값
// False
// False
// True
// True
// 3

// Nullable 형식의 이름은 Null(비어있는) + able(~될 수 있는), 즉, "비어 있는 상태가 될 수 있는"
// int? a = null; "해당 변수를 비운다"
