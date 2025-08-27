using System;

class URI
{

    static void Main(string[] args)
    {

        int pos = 0, neg = 0, imp = 0, par = 0;

        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            par++;
        }
        else
        {
            imp++;
        }

        if (n > 0)
        {
            pos++;
        }
        else if (n < 0)
        {
            neg++;
        }

        n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            par++;
        }
        else
        {
            imp++;
        }

        if (n > 0)
        {
            pos++;
        }
        else if (n < 0)
        {
            neg++;
        }

        n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            par++;
        }
        else
        {
            imp++;
        }

        if (n > 0)
        {
            pos++;
        }
        else if (n < 0)
        {
            neg++;
        }

        n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            par++;
        }
        else
        {
            imp++;
        }

        if (n > 0)
        {
            pos++;
        }
        else if (n < 0)
        {
            neg++;
        }

        n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            par++;
        }
        else
        {
            imp++;
        }

        if (n > 0)
        {
            pos++;
        }
        else if (n < 0)
        {
            neg++;
        }

        Console.WriteLine(par + " valor(es) par(es)");
        Console.WriteLine(imp + " valor(es) impar(es)");
        Console.WriteLine(pos + " valor(es) positivo(s)");
        Console.WriteLine(neg + " valor(es) negativo(s)");

    }

}
