using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class FloatConversion
    {
        static void Main(string[] agrs)
        {
            float a = 69.6875f;
            Console.WriteLine("a : {0}", a);

            double b = (double)a;
            Console.WriteLine("b : {0}", b);

            Console.WriteLine("69.6875 == b : {0}", 69.6875 == b);

            float x = 0.1f;
            Console.WriteLine("x : {0}", x);

            double y = (double)x;
            Console.WriteLine("y : {0}", y);

            Console.WriteLine("0.1 == x : {0}", 0.1 == x);
        }
    }
}

// 결과 값
// a : 69.6875
// b : 69.6875
// 69.6875 == b : true
// x : 0.1
// y : 0.100000001490116
// 0.1 == y : False