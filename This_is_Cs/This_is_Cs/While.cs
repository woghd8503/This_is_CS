using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class While
    {
        static void Main(string[] args)
        {
            int i = 10;

            while (i > 0)
            {
                Console.WriteLine($"i : {i--}");
            }
        }
    }
}
// 결과값
// i : 10
// i : 9
// i : 8
// i : 7
// i : 6
// i : 5
// i : 4
// i : 3
// i : 2
// i : 1