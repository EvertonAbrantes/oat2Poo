using System;
//Atividade 01
class lista01
{
    static void Main(string[] args)
    {
        int a, b, c

        Console.WriteLine("Digite o valor de A: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de B: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de C: ");
        int c = int.Parse(Console.ReadLine());


        if (a + b < c)
        {
            Console.WriteLine("A soma de A + B é menor que C.");
        }
        else
        {
            Console.WriteLine("A soma de A + B é maior ou igual a C.");
        }

            Console.WriteLine("O valor de C é:");
    }
}

