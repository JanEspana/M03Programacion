using System;
namespace Binario
{
    public class Ex25
    {
        public static void Main()
        {
            Console.Write("Escribe un número y se devolverá su binario: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Binario(num));
        }
        public static int Binario(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            return ;
        }
    }
}
