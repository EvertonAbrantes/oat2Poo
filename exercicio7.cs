using System;
//atividade07

class oat2
{
    static void Main(string[] args)
    {
        int numero, result;

        Console.WriteLine("Digite um número inteiro:");
       int numero = int.Parse(Console.Readline));

        if (numero% 2 == 0)
        {
            result = numero + 5;
        }
        else
        {
            result = numero + 8;
        }

        Console.WriteLine("Este é o resultado:" + result);
    }   

}
