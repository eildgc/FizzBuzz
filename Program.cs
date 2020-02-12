using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir numeros del 1 al 100
            //Dividido entre 3 Fizz
            //Dividido entre 5 Buzz
            //Dividido entre ambas es FizzBuzz
            //Todos los demas imprimen solo el numero
            //loop/bucle
            
            //Primera condicion - Inicializacion. Que va a hacer antes de comenzar el for

            //segunda condicion - Antes de  comenzar la iteracion del for 
            //tercera condicion - que va a ejecutar despues de cada iteracion
            //i = i + 1
            //i++
            for(int i = 0; i <=100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                //En enteros
                // 3 / 3 = 1
                // 4 / 3 = 1
                //En decimales
                // 3 / 3 = 1.0
                // 4 / 3 = 1.33
                //Modulo (%)
                //3 % 3 = 0
                //4 % 3 = 1
                //es lo que queda abajo en una division
            }

            // while (true)
            // {
            // }

        
        }
    }
}
