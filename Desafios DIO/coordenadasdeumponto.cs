using System; 
using System.Globalization;

class Program {

    static void Main(string[] args) { 
        //complete os espaços em branco com sua solução para o problema

          string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0) {
                Console.WriteLine("Origem");
            }
            else if (x ==   0 ) {
                Console.WriteLine("Eixo Y");
            }
            else if (y ==  0   ) {
                Console.WriteLine("Eixo X");
            }
            else if (x >  0  && y >  0   ) {
                Console.WriteLine(  " Q1\n"    );
            }
            else if (x < 0.0 && y > 0.0) {
                Console.WriteLine( "Q2\n" );
            }
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine( "Q3\n" );
            }
            else {
                Console.WriteLine("Q4\n");
            }

    }

}
