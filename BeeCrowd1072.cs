using System;

class URI
{

    static void Main(string[] args)
    {

        int loop = int.Parse(Console.ReadLine());

        int dentro = 0, fora = 0;

        for (int i = 0; i < loop; i++)
        {
            int numero = int.Parse(Console.ReadLine());

            if(numero >= 10 && numero <= 20)
            {
                dentro++;
            }
            else if(numero < 10 || numero > 20)
            {
                fora++;
            }
        }

        Console.WriteLine(dentro + " in");
        Console.WriteLine(fora + " out");
    }

}
