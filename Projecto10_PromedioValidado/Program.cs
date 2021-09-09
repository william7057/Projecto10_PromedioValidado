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
                Console.Write("Ingrese la Nota {0} : ", x );
                Nota = int.Parse(Console.ReadLine());// 170 , 150 , 13 , 15 , 20
                if (Nota>=0 && Nota<=20)// True , False
                {
                    x = x + 1;
                    suma = suma + Nota;
                }
                else
                {
                    Console.WriteLine("Vuelva a ingresar la Nota ");
                }
            }
            double promedio = 0;
            promedio = suma / 5.0;
            Console.WriteLine("El Promedio es : {0}", promedio);
            Console.ReadKey();
        }
    }
}
