using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class StringConcatenate
    {
        static void Main(string[] args)
        {
            string result = "123" + "456";
            Console.WriteLine(result);

            result = "Hello" + " " + "World!";
            Console.WriteLine(result);
        }
    }
}

// 결과값
// 123456
// Hello World! 