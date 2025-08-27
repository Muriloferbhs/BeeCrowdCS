using System;

class URI
{

    static void Main(string[] args)
    {

        int loop = int.Parse(Console.ReadLine());
        int dentroDoIntervalo = int.Parse(Console.ReadLine());
        int foraDoIntervalo = int.Parse(Console.ReadLine());
       
        for (int i = 0; i < loop; i++)
        {
            int entrada = int.Parse(Console.ReadLine());

            if (entrada >= 10 && entrada <= 20)
            {
                dentroDoIntervalo++;
            }
            else
            {
                foraDoIntervalo++;
            }

        }

        Console.WriteLine(dentroDoIntervalo + " in");
        Console.WriteLine(foraDoIntervalo + " out");
    }

}
