using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Cs
{
    class RefReturn
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price :{price}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            RefReturn carrot = new RefReturn();
            ref int ref_local_price = ref carrot.GetPrice(); // ref_local_price를 수정하면 carrot.price의 내용도 바뀝니다.
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price :{ref_local_price}");
            Console.WriteLine($"Normal Local Price :{normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price :{ref_local_price}");
            Console.WriteLine($"Normal Local Price :{normal_local_price}");
        }
    }
}
// 결과값
// Price :100
// Ref Local Price :100
// Normal Local Price :100
// Price : 200
// Ref Local Price : 200
// Normal Local Price : 100

//