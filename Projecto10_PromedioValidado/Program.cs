using System;
using System.Collections.Generic;
using System.Text;

namespace Projecto10_PromedioValidado
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 1;
            int Nota=0;
            int suma = 0;

            while (x<=5) {
                Console.Write("Ingrese la Nota {0} : ", x);
                Nota = int.Parse(Console.ReadLine());//17 , 15 , 13 , 15 , 20
                if (Nota>=0 && Nota<=20)// True , False
                {
                    suma = suma + Nota;
                }
                else
                {
                    Console.WriteLine("Vuelva a ingresar la Nota ");
                }

                x = x + 1;
            }
            Console.WriteLine("La suma total es : {0}", suma);

            Console.ReadKey();
        }
    }
}
