using System;

namespace jogoVelhaBigBang
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdTeste = int.Parse(Console.ReadLine());
            string a, b;
            for (int i = 1; i <= qtdTeste; i++) //insira a variavel correta
            {
                string[] valores = Console.ReadLine().Split();
                a = valores[0];
                b = valores[1];
                if ((a == "tesoura" && b == "papel") || (a == "papel" && b == "pedra") //complete a solução
                    || (a == "pedra" && b == "lagarto") || (a == "lagarto" && b == "Spock")
                    || (a == "Spock" && b == "tesoura") || (a == "tesoura" && b == "lagarto")
                    || (a == "lagarto" && b == "papel") || (a == "papel" && b == "Spock")
                    || (a == "Spock" && b == "pedra") || (a == "pedra" && b == "tesoura"))
                    Console.WriteLine("Caso #{0}: Bazinga!", i);
                else if (b == a)   //complete a solucao
                    Console.WriteLine("Caso #{0}: De novo!", i);
                else
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }
        }
    }
}
