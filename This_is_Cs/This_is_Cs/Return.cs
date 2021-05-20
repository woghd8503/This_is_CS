using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class Return
    {
        static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void PrintPofile(string name, string phone)
        {
            if(name == "")
            {
                Console.WriteLine("이름을 입력해주세요");
                return;
            }

            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"10번째 피노나치 수 : {Fibonacci(10)}");

            PrintPofile("", "123-4567");
            PrintPofile("박상현", "456-1230");
        }
    }
}

// 결과값
// 10번째 피보나치 수 : 55
// 이름을 입력해주세요.
// Name:박상현, Phone:456-1230

// 재귀호출 Recursive Call
// 매서드가 자기 자신을 스스로 호출하는 것을 일컬어 재귀호출이라고 합니다.
// 조금 전의 Fibonacci() 메소드가 조건에 따라 또 다시 Fibonacci()함수 자신을 호출했지요?
// 재귀 호출이 없었다면 우리는 앞의 코드를 반복문을 이용하여 구성해야 했을 겁니다. 성능에 나쁜 영향을 줍니다.