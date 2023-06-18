using System;
//Atividade10
class oat2
{
    static void Main(string[] args)
    {
        decimal IMC, Peso, Altura;

        Console.WriteLine("Digite o seu Peso:");
        Peso = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua altura:");
        Altura = decimal.Parse(Console.ReadLine());

        IMC = Peso / (Altura * Altura);

        Console.WriteLine($"O IMC da pessoa é: {IMC}, o Peso é de: {Peso}, e a altura é de: {Altura}");

        if (IMC < 18.5m)
        {
            Console.WriteLine("A pessoa está abaixo do peso");
        }
        else if (IMC < 25)
        {
            Console.WriteLine("A pessoa está no peso normal");
        }
        else if (IMC < 30)
        {
            Console.WriteLine("A pessoa está acima do peso");
        }
        else
        {
            Console.WriteLine("A pessoa está obesa");
        }
    }
}
