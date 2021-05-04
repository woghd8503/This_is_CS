using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class Break
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("계속할까요?(예/아니요) : ");
                string answer = Console.ReadLine();

                if (answer == "아니오")
                    break;
            }
        }
    }
}

// 결과값
// 계속할까요?(예/아니오) : 예
// 계속할까요?(예/아니오) : 예
// 계속할까요?(예/아니오) : 예
// 계속할까요?(예/아니오) : 아니오

// Jump Statement
// break 탈출하다. 중단하다.
// continue
// goto
// return
// throw
