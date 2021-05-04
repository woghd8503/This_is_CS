using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class Switch1
    {
        static void Main(string[] args)
        {
            object obj = null;

            string s = Console.ReadLine();
            if (int.TryParse(s, out int out_i))
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;
            switch (obj)
            {
                case int i:
                    Console.WriteLine($"{i}는 int 형식입니다.");
                    break;
                case float f:
                    Console.WriteLine($"{f}는 float 형식입니다.");
                    break;
                default:
                    Console.WriteLine($"{obj}는 모르는 형식입니다.");
                    break;
            }
        }
    }
}
// 결과값
// 123
// 123는 int 형식입니다.

// 123.45
// 123.45는 float 형식입니다.

// 안녕하세요
// 안녕하세요는 모르는 형식입니다.

// TryParse{} vs Parse()
// C#에서 제공하는 기본숫자 형식은 문자열을 숫자로 변환하는 Parse()메소드를 제공
// 숫자 형식은 Parse()뿐만 아니라 TryParse() 메소드도 제공합니다. 이름에서 볼 수 있는 것처럼
// 두 메소드는 같은 기능을 합니다. 이 둘의 차이는 변환이 실패하는 경우를 어떻게 다루는가에 있습니다.
// Parse()메소드는 변환이 실패하면 예외Exception 것을 던집니다. 예외가 던져지면 프로그램은 현재의
// 코드의 실행을 멈추고 흐름을 다른 곳으로 이동하게 됩니다. 반변, TryParse()가 변환한 데이터는 두 번째
// 매개 변수에 저장됩니다. out이라는 키워드로 수식 되어 있습니다. 
// out 키워드를 출력 전용 매개 변수임을 나타내는 용도로 쓰인다는 정도만 알아두면 충분합니다.
