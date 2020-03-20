using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            int i;

            Console.Write("Escribe una palabra: ");

            palabra = Console.ReadLine();

            char[] array = palabra.ToCharArray();

            for (i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[array.Length - 1 - i])
                {
                    if (i == array.Length - 2)
                    {
                        Console.Write("Es palindromo ");
                    }
                    
                } else  {
                    if (i == array.Length - 2)
                    {
                        Console.Write("No es palindromo");
                    }

 
                }

            }

            


            Console.ReadKey();




        }
    }
}
