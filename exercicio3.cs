using System;
//Atividade03

class oat2
{

    static void Main(string[] args)
    {
        Console.WriteLine("Escreva um número");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine(" O numero é par:");
        }

        else
        {
            Console.WriteLine("O numero é impar:");
        }

    }
}