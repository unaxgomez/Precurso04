/*
 * Se desea conocer el lucky  number (número de la suerte) de cualquier persona. El número de la suerte se consigue reduciendo 
 * la fecha de nacimiento a un número de un solo dígito. Por ejemplo, la fecha de nacimiento de Emma es la siguiente: 
 * 16-08-1973 16+8+1973=1997 	1+9+9+7=26 	2+6=8. El número de la suerte de Emma será el 8.
 */
using System;

namespace _26_Ejercicio_Repaso_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu fecha de nacimiento (dd-mm-aaaa)");

            string fechausuario = Console.ReadLine();

            string reemplazadosuma = fechausuario.Replace("-", "");

            string subcadena1 = reemplazadosuma.Substring(0, 2);
            string subcadena2 = reemplazadosuma.Substring(2,2);
            string subcadena3 = reemplazadosuma.Substring(4);

            int dia = Convert.ToInt32(subcadena1);
            int mes = Convert.ToInt32(subcadena2);
            int año = Convert.ToInt32(subcadena3);

            int respuesta1 = dia + mes + año;

            string numerostring = respuesta1.ToString();

            string subcadenaA = numerostring.Substring(0,1);
            string subcadenaB = numerostring.Substring(1, 1);
            string subcadenaC = numerostring.Substring(2, 2);
            string subcadenaD = numerostring.Substring(3);

            int numero1 = Convert.ToInt32(subcadenaA);
            int numero2 = Convert.ToInt32(subcadenaB);
            int numero3 = Convert.ToInt32(subcadenaC);
            int numero4 = Convert.ToInt32(subcadenaD);
            

            int sumanumeros = numero1 + numero2 + numero3 + numero4;

            string numerostring2 = sumanumeros.ToString();

            string subcadenaAB = numerostring.Substring(0, 1);
            string subcadenaBC = numerostring.Substring(1);

            int numero1A = Convert.ToInt32(subcadenaAB);
            int numero2B = Convert.ToInt32(subcadenaBC);

            int sumanumeros2 = numero1A + numero2B;

            if (sumanumeros2 > 10)
            {

                string subcadenaAC = numerostring2.Substring(0, 1);
                string subcadenaBD = numerostring2.Substring(1);

                int numero1B = Convert.ToInt32(subcadenaAC);
                int numero2C = Convert.ToInt32(subcadenaBD);

                int sumanumeros3 = numero1B + numero2C;

                Console.WriteLine("Tu número de la suerte es " + sumanumeros3);

                
            }
            else
            {
                Console.WriteLine("Tu número de la suerte es " + sumanumeros2);
            }

            


            //Introduce aquí tu código  
        }
    }
}
