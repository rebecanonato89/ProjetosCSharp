using System;

namespace Quadrado_e_ao_Cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var numero = Int32.Parse(Console.ReadLine());

            if (numero != null)
            {
                for (int i = 1; i <= numero; i++)
                {
                    var numeros = $"{i} {i * i} {i * i * i}";
                    Console.WriteLine(numeros);
                }
            }
            else
            {
                Console.WriteLine("Insira um número!");
            }
        }
    }
}