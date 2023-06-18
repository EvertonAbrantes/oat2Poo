//Atividade 02

class Oat2
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o sexo (M ou F): ");
        string sexo = Console.ReadLine();

        Console.WriteLine("Digite o estado civil: ");
        string estadoCivil = Console.ReadLine();

        if (sexo == "F" && estadoCivil == "CASADA")
        {
            Console.WriteLine("Digite o tempo de casada (anos): ");
            int tempoCasada = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Estado Civil: " + estadoCivil);
            Console.WriteLine("Tempo de casada: " + tempoCasada + " anos");
        }
        else
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Estado Civil: " + estadoCivil);
        }

        Console.ReadLine();
    }
}
