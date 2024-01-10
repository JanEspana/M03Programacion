using System;
using System.Xml;

namespace MetodoRuso
{
    public class Ex24
    {
        public static void Main()
        {
            const string MSG = "Introduce el multiplicando: ", MSG2 = "Introduce el multiplicador: ";
            int num1, num2;
            Console.WriteLine(MSG);
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MSG2);
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iterativo: "+MultRusoIt(num1, num2));
            Console.WriteLine("Recursivo: "+MultRusoRec(num1, num2));
        }
        public static int MultRusoIt(int num1, int num2)
        {
            int output = 0;
            if (num2 % 2 == 1)
            {
                output = num1;
            }
            while (num2 > 1)
            {
                num1 *= 2;
                num2 /= 2;
                if (num2 % 2 == 1)
                {
                    output = output + num1;
                }
            }
            return output;
        }
        public static int MultRusoRec (int num1, int num2)
        {
            if (num2 == 1)
            {
                return num1;
            }
            if (num2%2 == 1)
            {
                return num1 + MultRusoRec(num1 * 2, num2 / 2);
            }
            return MultRusoRec(num1*2, num2/2);
        }
    }
}
