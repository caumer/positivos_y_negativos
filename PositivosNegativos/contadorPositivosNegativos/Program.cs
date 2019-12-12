using System;

namespace contadorPositivosNegativos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el numero a evaluar");
            int number = Convert.ToInt32(Console.ReadLine());

            int num = (number % 2);

            if (num == 0)
            {
                Console.WriteLine("\n El numero ingresado es Par");
            }
            else
            {
                Console.WriteLine("\n El numero ingresado es Impar");
            }



        }
    }
}
