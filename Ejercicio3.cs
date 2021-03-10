using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num, Cont;
            Num = 10 * 10;
            Cont = 0;
            do
            {
                Num = Num + 2;
                Cont++;
                Console.WriteLine(Num);
            } while (Cont < 10);
        }
    }
}
