using System;
using System.Threading;
using System.Threading.Tasks;

namespace paralelismoY
{
    class Program
    {
        public static void Main()
        {
            //Declarar y crear un array
            int[] Numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Normal foreach: ");
            foreach (var numeros in Numeros)
            {
                //Impresion del 1 al 100
                Console.WriteLine(longCalculation(numeros));
            }
           
			//Salida en desorden
            Console.WriteLine("Paralelismo foreach : ");
            Parallel.ForEach(Numeros, numeros => {
                Console.WriteLine(longCalculation(numeros));
            });
        }

        private static int longCalculation(int numeros)
        {
            Thread.Sleep(100); 
            return numeros * numeros;
        }
    }
}