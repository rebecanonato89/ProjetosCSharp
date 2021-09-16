using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;  //declare suas variaveis              ;
           A = int.Parse(Console.ReadLine());
           B = int.Parse(Console.ReadLine());
           C = int.Parse(Console.ReadLine());
           D = int.Parse(Console.ReadLine());
          //continue a solução
            Console.WriteLine("DIFERENCA = " +   (  A  *  B  -  C * D  ));
            Console.ReadKey();
        }
    }
}
