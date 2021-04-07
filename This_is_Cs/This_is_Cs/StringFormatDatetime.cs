using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace This_is_Cs
{
    class StringFormatDatetime
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 3, 23, 18, 22);

            WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            WriteLine("12시간 형식: {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

            CultureInfo ciko = new CultureInfo("ko-KR");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciko));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciko));
            WriteLine(dt.ToString(ciko));

            CultureInfo ciEn = new CultureInfo("en-US");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));
            WriteLine(dt.ToString(ciEn));
        }
    }
}

// 결과값
// 12시간 형식: 2018-11-03 오후 11:18:22 (토)
// 24시간 형식: 2018-11-03 23:18:22 (토요일)
//
// 2018-11-03 오후 11:18:22 (토)
// 2018-11-03 23:18:22 (토요일)
// 2018-11-03 오후 11:18:22
//
// 2018-11-03 PM 11:18:22 (Sat)
// 2018-11-03 23:18:22 (Saturday)
// 11/3/2018 11:18:22 PM