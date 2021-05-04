﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class Switch
    {
        static void Main(string[] args)
        {
            Console.Write("요일을 입력하세요.(일,월,화,수,목,금,토) : ");
            string day = Console.ReadLine();

            switch(day)
            {
                case "일":
                    Console.WriteLine("Sunday");
                    break;
                case "월":
                    Console.WriteLine("Monday");
                    break;
                case "화":
                    Console.WriteLine("Tuesday");
                    break;
                case "수":
                    Console.WriteLine("Wednesday");
                    break;
                case "목":
                    Console.WriteLine("Thursday");
                    break;
                case "금":
                    Console.WriteLine("Friday");
                    break;
                case "토":
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine($"{day}는(은) 요일이 아닙니다.");
                    break;
            }
        }
    }
}
// 결과값
// Switch
// 요일을 입력하세요. (일,월,화,수,목,금,토) : 화
// Tuesday