using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class Enum1
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK}
        static void Main(string[] args)
        {
            DialogResult result = DialogResult.YES;
            Console.WriteLine(result == DialogResult.YES);
            Console.WriteLine(result == DialogResult.NO);
            Console.WriteLine(result == DialogResult.CANCEL);
            Console.WriteLine(result == DialogResult.CONFIRM);
            Console.WriteLine(result == DialogResult.OK);
        }
    }
}
// 결과 값
// True
// False
// False
// False
// False

// 열거 형식의 각 요소는 기본적으로 컴파일러로부터 값을 자동으로 할당받지만, 프로그래머가 원하는
// 값을 직접 대입할 수도 있습니다.

// 열거 형식을 선언할 때 첫 번째 요소에는 프로그래머가 직접 값을 할당하고, 두 번재 요소부터는 
// 어떤 값도 할당하지 않으면 컴파일러가 두 번째 요소부터 자동으로 값을 할당하기 시작합니다.