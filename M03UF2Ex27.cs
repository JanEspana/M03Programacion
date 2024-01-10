using System;
namespace PrimeNum
{
    public class Ex27
    {
        public static void Main()
        {
            const string MSG = "Introdueix un nombre natural i diré si és primer o no: ", NOTNAT = "Aquest no és natural! ";
            int input, divisor = 2;
            Console.Write(MSG);
            input = Convert.ToInt32(Console.ReadLine());
            while (input < 1)
            {
                Console.Write(NOTNAT+MSG);
                input = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write(PrimeRec(input, divisor) ? "És primer" : "No és primer");
            
        }
        public static bool PrimeRec(int input, int divisor)
        {
            if (input == divisor)
            {
                return true;
            
            }
            else if (input % divisor == 0)
            {
                return false;
            }
            return PrimeRec(input, divisor + 1);
        }
    }
}
