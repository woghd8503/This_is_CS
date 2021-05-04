using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class Foreach
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4 };

            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}
// 결과값
// 0
// 1
// 2
// 3
// 4

// Foreach 문은 배열 or 컬렉션을 순회하며 각 데이터 요소에 차례대로 접근하도록 합니다.
// 편리하게도 배열 or 컬렉션의 끝에 도달하면 자동으로 반복이 종료됩니다.

