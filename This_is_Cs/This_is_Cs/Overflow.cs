using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class Overflow
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue;  // uint의 최대값은, 4294967295

            Console.WriteLine(a);

            a = a + 1;

            Console.WriteLine(a);
        }
    }
}

// 결과값
// 4294967295
// 0
// 넘처서 0으로 할당