using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class BoxingUnboxing
    {
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a; // a의 담긴 값을 박싱해서 힙에 저장
            object c = (int)b;    // b에 담긴 값을 언박싱해서 스택에 저장

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            double x = 3.1414213;
            object y = x;           // x에 담긴 값을 박싱해서 힙에 저장
            double z = (double)y;   // y에 담긴 값을 언박싱해서 스택에 저장

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
// 결과값
// 123
// 123
// 123
// 3.1414213
// 3.1414213
// 3.1414213