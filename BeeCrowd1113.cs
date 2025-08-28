using System;

class URI
{

    static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');



        int valor1 = int.Parse(entrada[0]);
        int valor2 = int.Parse(entrada[1]);

        while (valor1 != valor2)
        {

            if (valor1 > valor2)
            {
                Console.WriteLine("Decrescente");
            }
            else if (valor1 < valor2)
                {
                    Console.WriteLine("Crescente");
                }

            entrada = Console.ReadLine().Split(' ');

            valor1 = int.Parse(entrada[0]);
            valor2 = int.Parse(entrada[1]);
        }

    }
}
