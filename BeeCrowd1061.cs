using System;

class URI
{

    static void Main(string[] args)
    {
        string[] dia1 = Console.ReadLine().Split(' ');

        int dias1 = int.Parse(dia1[1]);

        string[] horario1 = Console.ReadLine().Split(' ');

        int horas1 = int.Parse(horario1[0]);
        int minutos1 = int.Parse(horario1[2]);
        int segundos1 = int.Parse(horario1[4]);



        string[] dia2 = Console.ReadLine().Split(' ');

        int dias2 = int.Parse(dia2[1]);

        string[] horario2 = Console.ReadLine().Split(' ');

        int horas2 = int.Parse(horario2[0]);
        int minutos2 = int.Parse(horario2[2]);
        int segundos2 = int.Parse(horario2[4]);

        //Console.WriteLine(dias1);
        //Console.WriteLine(horas1);
        //Console.WriteLine(minutos1);
        //Console.WriteLine(segundos1);
        //Console.WriteLine(dias2);
        //Console.WriteLine(horas2);
        //Console.WriteLine(minutos2);
        //Console.WriteLine(segundos2);

        int diastotais;
        int horastotais;
        int minutostotais;
        int segundostotais;


        segundos1 = (dias1 * 24 * 60 * 60) + (horas1 * 60 * 60) + (minutos1 * 60) + segundos1;
        segundos2 = (dias2 * 24 * 60 * 60) + (horas2 * 60 * 60) + (minutos2 * 60) + segundos2;


        segundostotais = segundos2 - segundos1;

        minutostotais = segundostotais / 60;
        segundostotais = segundostotais % 60;


        horastotais = minutostotais / 60;
        minutostotais = minutostotais % 60;

        diastotais = horastotais / 24;
        horastotais = horastotais % 24;

        Console.WriteLine(diastotais + " dia(s)");
        Console.WriteLine(horastotais + " hora(s)");
        Console.WriteLine(minutostotais + " minuto(s)");
        Console.WriteLine(segundostotais + " segundo(s)");


    }
}
