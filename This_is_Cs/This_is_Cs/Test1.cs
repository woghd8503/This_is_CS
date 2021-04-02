using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class Test1
    {
        static void Main(string[] args)
        {
            // 사각형의 넓이를 구해라
            Console.WriteLine("사각형의 너비를 입력하세요.");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요");
            string height = Console.ReadLine();

            int a = Int32.Parse(width) * Int32.Parse(height);

            Console.WriteLine("사각형의 넓이는 {0}", a);
        }
    }
}
