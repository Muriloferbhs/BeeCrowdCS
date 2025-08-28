using System;

class URI
{

    static void Main(string[] args)
    {

        int divisor = int.Parse(Console.ReadLine());


        int i = 0;
        while (i < 10000){

            if (i % divisor == 2)
            {
                Console.WriteLine(i);
            }

            i++;
        }


    }

}
