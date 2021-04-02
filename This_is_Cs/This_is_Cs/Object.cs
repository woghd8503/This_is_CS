using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class Object
    {
        static void Main(string[] args)
        {
            object a = 123;
            object b = 3.14159253589793238462643383279m;
            object c = true;
            object d = "안녕하세요.";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}

// 결과값
// 123
// 3.1415925358979323846264338328
// True
// 안녕하세요.

// object 형식은 참조 형식이기 때문에 힙에 데이터를 할당합니다. int 형식이나 double 형식은 값
// 형식이기 때문에 스택에 데이터를 할당하고요.

// object 형식은 값 형식의 데이터를 힙에 할당하기 위한 "박싱Boxing" 기능을 제공합니다. 