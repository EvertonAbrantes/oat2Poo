using System;
//Atividade11
class oat2
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Informe o preço normal de etiqueta do produto:");

        decimal precoEtiqueta = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Escolha a condição de pagamento:");

        Console.WriteLine("1 À vista em dinheiro ou cheque");

        Console.WriteLine("2 À vista no cartão de crédito");

        Console.WriteLine("3 Dividido em duas vezes");

        Console.WriteLine("4 Dividido em duas vezes no cartão de crédito");

        int opcao = int.Parse(Console.ReadLine());

        decimal precoFinal = 0;

        switch (opcao)
        {
            case 1:
                precoFinal = precoEtiqueta - (precoEtiqueta * 0.1m);
                break;
            case 2:
                precoFinal = precoEtiqueta - (precoEtiqueta * 0.15m);
                break;
            case 3:
                precoFinal = precoEtiqueta;
                break;
            case 4:
                precoFinal = precoEtiqueta + (precoEtiqueta * 0.1m);
                break;
            default:
                Console.WriteLine("Opção inválida");
                return;
        }

        Console.WriteLine("O valor a ser pago é: " + precoFinal.ToString("C"));
    }
}
