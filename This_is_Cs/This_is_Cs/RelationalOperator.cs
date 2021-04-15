using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class RelationalOperator
    {
       static void Main(string[] args)
        {
            Console.WriteLine($"3 > 4 : {3 > 4}");
            Console.WriteLine($"3 >= 4 : {3 >= 4}");
            Console.WriteLine($"3 < 4 : {3 < 4}");
            Console.WriteLine($"3 <= 4 : {3 <= 4}");
            Console.WriteLine($"3 == 4 : {3 == 4}");
            Console.WriteLine($"3 != 4 : {3 != 4}");
        }
    }
}
// 결과값
// 3 > 4 : False
// 3 >= 4 : False
// 3 < 4 : True
// 3 <= 4 : True
// 3 == 4 : False
// 3 !=4 : True