using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class InfiniteWhile
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
                Console.WriteLine(i++);
        }
    }
}
// 결과값
// .....
// 55555
// 55556
// 55557
// .....