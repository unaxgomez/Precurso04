/*
 * En este ejercicio queremos que muestres en pantalla una cuenta atrás de 10 a 0 
 * (usando un _while_) y al llegar a 0 que muestre ¡Despegue!
 */

using System;

namespace _13_Ejercicio_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 10;

            while (x >= 0)
            {
                Console.WriteLine(x);
                x = x - 1;

              
                if (x == 0)
                {
                    Console.WriteLine(x);
                    Console.WriteLine("¡Despegue!");
                    break;

                }
                    }
                // Tu código aquí
        }
    }
}
