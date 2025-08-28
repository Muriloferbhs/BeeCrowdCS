using System;

class URI
{

    static void Main(string[] args)
    {


        String grupo1 = Console.ReadLine();
        String grupo2 = Console.ReadLine();
        String grupo3 = Console.ReadLine();


        if (grupo2 == "ave")
        {
            if (grupo3 == "carnivoro")
            {
                Console.WriteLine("aguia");
            }

            if (grupo3 == "onivoro")
            {
                Console.WriteLine("pomba");
            }

        }

        else if (grupo2 == "mamifero")
        {
            if (grupo3 == "onivoro")
            {
                Console.WriteLine("homem");
            }

            if (grupo3 == "herbivoro")
            {
                Console.WriteLine("vaca");
            }

        }

        else if (grupo2 == "inseto")
        {
            if (grupo3 == "hematofago")
            {
                Console.WriteLine("pulga");
            }

            if (grupo3 == "herbivoro")
            {
                Console.WriteLine("lagarta");
            }

        }

        else if (grupo2 == "anelideo")
        {
            if (grupo3 == "hematofago")
            {
                Console.WriteLine("sanguessuga");
            }

            if (grupo3 == "onivoro")
            {
                Console.WriteLine("minhoca");
            }

        }
    }
}
