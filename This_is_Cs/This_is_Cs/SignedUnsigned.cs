using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class SignedUnsigned
    {
        static void Main(string[] args)
        {
            byte a = 255;
            sbyte b = (sbyte)a;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
