using System;
//Atividade08
class oat2
{
    static void Main()
    {
       
        int[] numeros = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Digite o {0}º número inteiro: ", i + 1);
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numeros);
        Array.Reverse(numeros);

        Console.WriteLine("Números em ordem decrescente:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
