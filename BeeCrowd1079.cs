using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        double loop = double.Parse(Console.ReadLine());
        string[] numeros;
        for (int i = 0; i < loop; i++)
        {
            numeros = Console.ReadLine().Split(' ');

            double primeiraNota = double.Parse(numeros[0]);
            double segundaNota = double.Parse(numeros[1]);
            double terceiraNota = double.Parse(numeros[2]);

            double media = ((primeiraNota * 2) + (segundaNota * 3) + (terceiraNota * 5)) / 10;

            string resultado = $"{media:F1}";

            Console.WriteLine(resultado = resultado.Replace(',', '.'));


        }

    }

}
