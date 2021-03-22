using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int sair = 0;

            do
            {

                Console.WriteLine("Digite o Nome: ");
                nome = Console.ReadLine();

                if (nome.ToLower().Contains("maria"))
                //o .ToLower transforma a string em mínuscula. 
                // o .Contains verifica se na string digitada contém o maria.
                {
                    Console.WriteLine("O Prenome é Maria. ");
                }
                else
                {
                    Console.WriteLine("O Prenome NÃO é Maria. ");
                }

                Console.WriteLine("para permanecer digite 0 ");
                
                sair = Int32.Parse(Console.ReadLine());

            } while (sair == 0);
        }
    }
}
