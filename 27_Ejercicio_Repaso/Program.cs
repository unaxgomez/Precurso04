//using System;

//namespace _Ejercicio_Repaso
//{
//    class MainClass
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Introduce un número");

//            string numerousuario = Console.ReadLine();

//            int numero = Convert.ToInt32(numerousuario);



//            for (int y = 0; y < numero; y++)
//            {

//                string linea = "";

//                for (int x = 0; x < numero; x++)
//                {

//                    if (y % 2 == 0)
//                    {
//                        if (x % 2 == 0)
//                        {
//                            linea += "X"; // linea = linea + "X"
//                        }
//                        else
//                        {
//                            linea += "O";
//                        }
//                    }
//                    else
//                    {
//                        if (x % 2 == 0)
//                        {
//                            linea += "O"; // linea = linea + "X"
//                        }
//                        else
//                        {
//                            linea += "X";
//                        }
//                    }


//                }

//                Console.WriteLine(linea);
//            }
//        }
//    }
//}


using System;

namespace _Ejercicio_Repaso
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número");

            string numerousuario = Console.ReadLine();

            int numero = Convert.ToInt32(numerousuario);



            for (int y = 0; y < numero; y++)
            {

                string linea = "";

                for (int x = 0; x < numero; x++)
                {
                        if ((x+y) % 2 == 0)
                        {
                            linea += "X"; // linea = linea + "X"
                        }
                        else
                        {
                            linea += "O";
                        }
      
                }

                Console.WriteLine(linea);
            }
        }
    }
}
