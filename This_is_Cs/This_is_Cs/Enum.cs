using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class Enum
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);
        }
    }
}

// 결과 값 
// 0
// 1
// 2
// 3
// 4

// C#의 열거 형식이 이렇게 설계된 이유는 열거 형식의 요소가 어떤 값을 갖느냐는 별
// 의미가 없기 때문입니다. 열거형식의 각 요소는 서로 중복되지 않는 값을 갖고 있는데 의미가 있습니다.