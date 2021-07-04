using System;

namespace calculo_fibonacci_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos imprimir a seguência de fibonacci, a seguência será número que você digitar...");
            Console.ReadKey();
            Console.WriteLine("Digite um número...");
            int quantVezesSequenciaUsuario = int.Parse(Console.ReadLine());
            double x = 0;
            double y = 1;

            Console.Write(x + ", ");
            Console.Write(y + ", ");


            for (int i = 0; i < quantVezesSequenciaUsuario; i++)
            {
                double z = x + y;
                Console.Write(z + ", ");
                x = y;
                y = z;
            }

        }
    }
}
