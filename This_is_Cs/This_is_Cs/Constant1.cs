using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class Constant1
    {
        static void Main(string[] args)
        {
            const int a = 3;
            a = 4;
        }
    }
}

// 결과 값
// fail : 할당식의 왼쪽은 변수, 속성 또는 인텍서여야 합니다.