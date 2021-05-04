using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class GoTo
    {
        static void Main(string[] args)
        {
            Console.Write("종료 조건(숫자)을 입력하세요 :");

            string input = Console.ReadLine();

            int input_number = Convert.ToInt32(input);

            int exit_number = 0;

            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    for(int k = 0; k < 3; k++)
                    {
                        if (exit_number++ == input_number)
                            goto EXIT_FOR;

                        Console.WriteLine(exit_number);
                    }
                }
            }

            goto EXIT_PROGRAM;

        EXIT_FOR:
            Console.WriteLine("\nExit nested for...");

        EXIT_PROGRAM:
            Console.WriteLine("Exit program...");
        }
    }
}
// 결과값
// 종료 조건(숫자)을 입력하세요 :5
// 1
// 2
// 3
// 4
// 5

// Exit nested for...
// Exit program...

// 종료 조건(숫자)을 입력하세요 : 20
// 1
// 2
// 3
// 4
// 5
// 6
// 7
// 8
// 9
// 10
// 11
// 12
// Exit program...

// goto 문은 점프문 중에서도 가장 터프한 점프문입니다. 사용형식에서 Label 레이블을 사용
// 텔레포트 goto JUMP; JUMP: 상당수의 프로그래머들은 goto문을 좋아하지 않음. 코드의 흐름을 끊음.