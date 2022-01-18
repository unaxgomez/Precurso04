/*
 * En este ejercicio, debes pedirle al usuario que introduzca su edad. Si es igual o mayor a 18, 
 * mostrarás en pantalla "Eres mayor de edad" y en caso contrario "Eres menor".
 */
using System;

namespace _06_Ejercicio_If_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu edad");

            string edadusuario;
            edadusuario = Console.ReadLine();

            int edad;
            edad = Convert.ToInt32(edadusuario);

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
                { 
                Console.WriteLine("Eres menor de edad");
            }


            // Tu código aquí
        }
    }
}
