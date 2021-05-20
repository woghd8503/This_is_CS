using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class Method
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class MainApp
    {
        public static void Main()
        {
            int result = Method.Plus(3, 4);
            Console.WriteLine("Plus 결과 값:{0}", result);

            result = Method.Minus(5, 2);
            Console.WriteLine("Minus 결과 값:{0}", result);
        }
    }
}
// 결과값
// Plus 결과 값: 7
// Minus 결과 값: 3

// static 한정자
// static 은 메소드나 필드가 클래스의 인스턴스가 아닌 클래스 자체에 소속되도록 지정하는 한정자입니다.