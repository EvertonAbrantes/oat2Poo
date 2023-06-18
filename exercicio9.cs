using System;
//Atividade09
class oat09
{
    static void Main(string[] args)
    { 
      double altura, pesoideal
      string sexo


        Console.Write("Insira sua altura em metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escreva seu sexo (masculino ou feminino): ");
        string sexo = Console.ReadLine();

        double pesoIdeal;

        if (sexo == "M")
        {
            pesoIdeal = (72.7 * altura) - 58;
        }
        else if (sexo == "F")
        {
            pesoIdeal = (62.1 * altura) - 44.7;
        }
        else
        {
            Console.WriteLine("Sexo inválido. Por favor, informe 'masculino' ou 'feminino'.");
            return;
        }

        Console.WriteLine("Seu peso ideal é: " + pesoIdeal.ToString("") + " kg.");
    }
}
