using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class SwapByRef
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x:{x}, y:{y}");

            Swap(ref x, ref y);

            Console.WriteLine($"x:{x}, y:{y}");
        }
    }
}
// 결과값
// x:3, y:4
// x:3, y:4

// 매개 변수를 "참조에 의한 전달 pass by reference"로 넘기면 Swap() 메소드가
// 제대로 일을 할 수 있습니다. 값에 의한 전달이 매개 변수가 변수나 상수로부터
// 값을 복사하는 것과는 달리, 참조에 의한 전달은 매개 변수가 메소드에 넘겨진 원본 변수를 직접
// 참조합니다. 따라서 메소드 안에서 메개 변수를 수정하면 이 매개 변수가 참조하고 있는 원본 변수에 수정이 
// 이루어집니다.