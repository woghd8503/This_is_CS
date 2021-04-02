using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class StringNumberConversion
    {
        static void Main(string[] args)
        {
            int a = 123;
            string b = a.ToString();
            Console.WriteLine(b);

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine(d);

            string e = "123456";
            int f = Convert.ToInt32(e);
            Console.WriteLine(f);

            string g = "1.2345";
            float h = float.Parse(g);
            Console.WriteLine(g);
        }
    }
}

// 결과 값
// 123
// 3.14
// 12345
// 1.2345

// int to string : a.Tostring();
// float to string : c.Tostring();
// string to int : Convert.Int32(e);
// string to float : float.Parse(g);