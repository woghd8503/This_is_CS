using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class LogicalOperator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing && ...");
            Console.WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}");
            Console.WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");
            Console.WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");
            Console.WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");

            Console.WriteLine("\nTesting || ... ");
            Console.WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}");
            Console.WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}");
            Console.WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");
            Console.WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 > 5}");

            Console.WriteLine("\nTesting ! ...");
            Console.WriteLine($"!True : {!true}");
            Console.WriteLine($"!False: {!false}");
        }
    }
}

// Testing && ...
// 1 > 0 && 4 < 5 : True
// 1 > 0 && 4 > 5 : False
// 1 == 0 && 4 > 5 : False
// 1 == 0 && 4 < 5 : False

// Testing || ...
// 1 > 0 || 4 < 5 : True
// 1 > 0 || 4 > 5 : True
// 1 == 0 || 4 > 5 : False
// 1 == 0 || 4 < 5 : True

// Testing !...
// !True : False
// !False: True