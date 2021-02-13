using System;

namespace negativoocero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numP;
            int numP2;
            int numP3;
            int numP4;
            int numP5;

            do
            {
                Console.WriteLine("Ingrese un numero positivo: ");
                numP = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero: ");
                numP2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero: ");
                numP3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero: ");
                numP4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero: ");
                numP5 = Convert.ToInt32(Console.ReadLine());
            } while (numP > 0 && numP2 > 0 && numP3 > 0 && numP4 > 0 && numP5 > 0);


            Console.WriteLine("Esta es la suma de los numeros ingresados anteriormente: ");
            Console.WriteLine(numP + numP2 + numP3 + numP4 + numP5);
            
        }
    }
}
