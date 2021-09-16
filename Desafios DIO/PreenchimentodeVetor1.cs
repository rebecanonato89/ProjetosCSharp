using System;

namespace vetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorLido = int.Parse(Console.ReadLine());
            int[] n = new int[10];    


            for(int i = 0; i< 10; i++)
            {
                if(i == 0){
                 n[i]= valorLido;
               } else {
                 n[i] = n[i-1]*2;
               }
            }
            for (int i  = 0; i < 10; i++)
            {
                Console.WriteLine($"N[{i}] = {n[i]}");
            }
        }
    }
}
