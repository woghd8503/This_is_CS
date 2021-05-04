using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class DoWhile
    {
        static void Main(string[] args)
        {
            int i = 10;
            do
            {
                Console.WriteLine("a) i : {0}", i--);
            }
            while (i > 0);

            do
            {
                Console.WriteLine("b) i : {0}", i--);
            }
            while (i > 0);
        }
    }
}
// 결과값
// a) i : 10
// a) i : 9
// a) i : 8
// a) i : 7
// a) i : 6
// a) i : 5
// a) i : 4
// a) i : 3
// a) i : 2
// a) i : 1
// b) i : 0