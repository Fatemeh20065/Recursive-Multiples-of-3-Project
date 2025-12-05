using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_question
{
    class Program
        {
                // متد بازگشتی برای نمایش مضرب‌های ۳
             static void PrintMultiplesOfThree(int number, int current)
             {
                // شرط پایان: وقتی current به صفر رسید
                if (current <= 0)
                return;

                // اگر current مضرب ۳ باشد، چاپ کن
                if (current % 3 == 0)
                Console.WriteLine(current);

                // فراخوانی بازگشتی با عدد کوچکتر
                PrintMultiplesOfThree(number, current - 1);
            }

            static void Main()
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Multiples of 3 less than {0}:",number);
                PrintMultiplesOfThree(number, number - 1);
                Console.ReadKey();
    }
}

}
