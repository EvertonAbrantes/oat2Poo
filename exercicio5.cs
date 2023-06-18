using System;
//Atividade05
class oat2 


{
    static void Main(string[] args)
    {
        
        double num resultado;

        Console.WriteLine("Escreva um número: ");
        num = int.Parse(Console.ReadLine());

        if (num >= 0)
        {
            resultado = num * 3;
        }
        else
        {
            resultado = num * 2;
        }

        Console.WriteLine("O resultado dessa operação é: " + resultado);
    }
}







