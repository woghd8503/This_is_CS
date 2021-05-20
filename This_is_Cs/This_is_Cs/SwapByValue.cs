using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class SwapByValue
    {
        public static void Swap(int a, int b)
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

            Swap(x, y);

            Console.WriteLine($"x:{x}, y:{y}");
        }
    }
}
// 결과값
// x:3, y:4
// x:3, y:4

// 메소드를 호출할 때 데이터를 복사해서 매개 변수에 넘기는 값을 "값에 의한 전달"이라고 부릅니다.
