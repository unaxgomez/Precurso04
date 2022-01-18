/*
 * Escribe un programa que muestre todos los valores pares o impares entre 1 y 100 dependiendo de si el usuario introduce P o I . 
 * Si introduce otra cosa, decir que ese valor no es correcto y pedirle otra vez. 
 */
using System;

namespace _22_Ejercicio_Repaso_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca P para obtener los números pares del 1 al 100 o I para impares");

            string usuario;
            usuario = Console.ReadLine();


            //"hola";


            /* if (usuario == "P")
             {
                 for (int p = 0; p <= 100; p = p + 2)
                 {
                     Console.WriteLine(p);
                 }

             }
             else if (usuario == "I")
             {
                 for (int i = 1; i <= 100; i = i + 2)
                 {
                 Console.WriteLine(i);
                 }
         }

             else
             {
                 Console.WriteLine("Introduce un carácter válido");

             } */

            switch (usuario)
            {
                case "P":
                    for (int p = 0; p <= 100; p = p + 2)
                    {
                        Console.WriteLine(p);
                    }
                    break;
                case "I":
                    for (int i = 1; i <= 100; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                default:
                    Console.WriteLine("Introduce un carácter válido");
                    break;
            }


            //Introduce aquí tu código


        }
    }
}
