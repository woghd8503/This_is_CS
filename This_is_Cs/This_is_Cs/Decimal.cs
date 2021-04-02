using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class Decimal
    {
        static void Main(string[] args)
        {
            float   a = 3.1415_9296_3589_7932_3846_2643_3832_79f; // float 뒤에는 f를 붙힌다.
            double  b = 3.1415_9296_3589_7932_3846_2643_3832_79;  // 아무것도 없으면 double
            decimal c = 3.1415_9296_3589_7932_3846_2643_3832_79m; // decimal 뒤에는 m을 붙힌다.

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
// 결과 값
// 3.141593
// 3.14159296358979
// 3.1415929635897932384626433833