using System;

namespace This_is_Cs
{
    class ConditionalOperator
    {
        static void Main(string[] args)
        {
            string result = (10 % 2) == 0 ? "짝수" : "홀수";

            Console.WriteLine(result);
        }
    }
}

// 결과 값
// 짝수

// 조건 연산자 Conditional Operator ?:는 피연산자가 세개가 됩니다.
