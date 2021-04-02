using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class IntegralTypes
    {
        static void Main(string[] args)
        {
            sbyte a = -10;
            byte b = 40;

            Console.WriteLine($"a={a}, b={b}");

            short c = -3000;
            ushort d = 60000;

            Console.WriteLine($"c={c}, d={d}");

            int e = -1000_0000; // 0이 7개
            uint f = 3_0000_0000; // 0이 8개

            Console.WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000; // 0이 11개
            ulong h = 200_0000_0000_0000_0000; // 0이 18개 

            Console.WriteLine($"g={g}, h={h}");
        }
    }
}

// 바이트 
// 오늘날 우리가 접하는 거의 모든 컴퓨터는 8비트bit를 바이트byte로 취급합니다.
// 그러니까 1바이트는 다음과 같이 8개의 0과 1로 구성된 데이터 덩어리입니다.

// 129(10진수) = 1000 0001(2진수)

// 어떤 컴퓨터에서는 60비트를 한 바이트로 취급하기도 하고 12바이트나 36비트를 한 바이트로 취급
// 하기도 했습니다. "8비트 = 1바이트"로 사용한 것은 IBM의 System/360 컴퓨터가 시초였는데,
// 사실상의 표준으로 굳어지기 시작한 것은 8비트 마이크로프로세서가 득세한 70년대부터로 알려져
// 있습니다. 오늘날 대부분의 컴퓨터에서는 8비트를 1바이트로 취급합니다.
