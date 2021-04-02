using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class UsingVar
    {
        static void Main(string[] args)
        {
            var a = 20;
            Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a);

            var b = 3.1414213;
            Console.WriteLine("Type: {0}, Value: {1}", b.GetType(), b);

            var c = "Hello, World!";
            Console.WriteLine("Type: {0}, Value: {1}", c.GetType(), c);

            var d = new int[] { 10, 20, 30 }; // 배열도 var로 선언할 수 있습니다.
            Console.Write("Type: {0}, Value: ", d.GetType());

            foreach (var e in d)
                Console.Write("{0} ", e);

            Console.WriteLine();
        }
    }
}

// 결과 값
// Type: System.Int32, Value: 20
// Type: System.Double, Value: 3.1414213
// Type: System.String, Value: Hello, World!
// Type: System.Int32[], Value: 10 20 30

// var 키워드를 이용해서 변수를 선언하려면 반드시 선언과 동시에 초기화를 해줘야 합니다.
// var 는 지역 변수로만 사용할 수 있습니다.
// 클래스의 필드를 선언할 때는 반드시 명시적 형식을 선언해야 합니다. 클래스의 필드는 선언과 같이
// 초기화 하지 않는 경우가 많은데(나중에 배우겠지만 생성자라고 하는 특수한 메소들에서 초기화를 하는)
// 경우가 대부분입니다.) var 키워드로 필드를 선언하면 컴파일러가 무슨 형식인지 파악할 길이 없기 
// 때문입니다.

// object a = 20; 형식은 CLR은 20을 박싱해서 힙에 넣어넣고 a가 힙을 가리키도록 만들 겁니다.
// var a = 20; 형식은 CLR이 해당 코드를 실행할 때는 a가 var로 선언되었는지좋차 눈치채지 못하고
// int 형식의 객체 a에 20을 담아 스택에 올립니다.