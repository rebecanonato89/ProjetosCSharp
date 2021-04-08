using System;

namespace programaDoErick
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int numeroInserido = 0;
            string nomeDaPessoa = "";
            string sobrenomeDaPessoa = "";

            Console.WriteLine("Erick Digite um nome na tela: ");
            //numeroInserido = Convert.ToInt32(Console.ReadLine());
            nomeDaPessoa = Console.ReadLine();
            sobrenomeDaPessoa = Console.ReadLine();

            //if(numeroInserido == 5)
            //{
            //    Console.WriteLine("Erick vc está entendendo????");
            //}else
            //{
            //    Console.WriteLine("Erick não se sinta tão perdido! ");
            //}

            if (nomeDaPessoa == "rebeca")
            {
                Console.WriteLine("A Rebeca vai te ajudar....");
                if (sobrenomeDaPessoa == "nonato")
                {
                    Console.WriteLine("A Rebeca NONATO vai te ajudar....");
                }
                else
                {
                    Console.WriteLine("o sobrenome não é nonato");
                }
            }
            else
            {
                Console.WriteLine("Sempre solicite ajuda quando precisar...");
            }


        }
    }
}
