using System;
namespace SumDigits
{
    public class Ex26
    {
        public static void Main()
        {
            const string MSG = "Introdueix un nombre: ";
            int input;
            Console.WriteLine(MSG);
            input = Convert.ToInt32(Console.ReadLine());
            Console.Write(SumDigitsRec(input));
        }
        public static int SumDigitsRec(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            return num % 10 + SumDigitsRec(num / 10);
        }
    }
}
