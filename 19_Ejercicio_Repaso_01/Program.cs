/*
 * Escribe un programa que muestre  en pantalla “Feliz cumpleaños” repetido tantas veces como años tenga.
 */
using System;

namespace _19_Ejercicio_Repaso_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos años tienes?");

            string edadtexto;
                edadtexto = Console.ReadLine();

            int edad;
            edad = Convert.ToInt32(edadtexto);

            int x;
            x = 0;
            while (x <= edad)
            {
                Console.WriteLine();
                x = x + 1;

                Console.WriteLine("Feliz cumpleaños");
            }
        }

        // Tu código aquí
    }
    
}
