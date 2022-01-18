/*
 * Escribe un programa que pida un número de 3 dígitos y muestre el resultado de sumar sus dígitos.
 */
using System;

namespace _25_Ejercicio_Repaso_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número de 3 dígitos");

            string numerousuario;
            numerousuario = Console.ReadLine();

            // int numero = Convert.ToInt32(numerousuario);

            string subcadena1 = numerousuario.Substring(0,1);
            string subcadena2 = numerousuario.Substring(1,1);
            string subcadena3 = numerousuario.Substring(2);

            int num1 = Convert.ToInt32(subcadena1);
            int num2 = Convert.ToInt32(subcadena2);
            int num3 = Convert.ToInt32(subcadena3);

            int respuesta = num1 + num2 + num3;

            Console.WriteLine(respuesta);






            //Introduce aquí tu código   
        }
    }
}
