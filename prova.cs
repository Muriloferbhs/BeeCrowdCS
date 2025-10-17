using System.Net.Http.Headers;

string entrada = Console.ReadLine();

bool temounao = false;
int contAbrir = 0;
int contFechar = 0;
foreach (char a in entrada)
{
    if (a == '(')
    {
        contAbrir++;
    }
    if (a == ')')
    {
        contFechar++;
    }
}
if (contAbrir != contFechar)
{
    Console.WriteLine("incorrect");
}
else
{
    char[] entradaArray = entrada.ToCharArray();

    for (int i = 0; i < entradaArray.Length; i++)
    {
        if (entradaArray[i] == ')')
        {
            temounao = false;
            for (int j = 0; j <= i; j++)
            {
                if (entradaArray[j] == '(')
                {
                    temounao = true;
                }
            }
        }
    }
    for (int i = entradaArray.Length - 1; i <= 0; i--)
    {
        if (entradaArray[i] == '(')
        {
            temounao = false;
            for (int j = entradaArray.Length -1 ; j > i; j--)
            {
                if (entradaArray[j] == ')')
                {
                    temounao = true;
                }
            }
        }
    }
    if (temounao == false)
    {
        Console.WriteLine("incorrect");
    }
    else
    {
        Console.WriteLine("correct");
    }
}

