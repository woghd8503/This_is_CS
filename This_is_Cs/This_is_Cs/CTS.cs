using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class CTS
    {
        static void Main(string[] args)
        {
            System.Int32 a = 123;
            int b = 456;

            Console.WriteLine("a type:{0}, value:{1}", a.GetType().ToString(), a);
            Console.WriteLine("a type:{0}, value:{1}", b.GetType().ToString(), b);

            System.String c = "abc";
            string d = "def";

            Console.WriteLine("c type:{0}, value:{1}", c.GetType().ToString(), c);
            Console.WriteLine("c type:{0}, value:{1}", d.GetType().ToString(), d);
        }
    }
}

// 결과 값
// a type:System.Int32, value:123
// a type:System.Int32, value:456
// a type:System.String, value:abc
// a type:System.String, value:def

// GetType() 메소드와 ToString() 메소드
// 모든 데이터 형식은 object 형식으로부터 상속받는다고 한 사실, 기억하고 있지요? 상속을 받으며
// 부모가 가진 것을 모두 물려받습니다. 우리가 CTS 예제 코드에서 사용한 GetType()과 ToString()
// 메소드는 사실 System.Int32와 int, System.String과 string 형식이 objec 형식으로 물려받아 같고
// 있슨 것입니다.