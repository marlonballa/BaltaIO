class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Menu();
    }

    static void Soma() {
        Console.WriteLine("Digite o primeiro valor: ");
        float firstValue = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o primeiro valor: ");
        float secondValue = float.Parse(Console.ReadLine());
        var result =  firstValue + secondValue;
        Console.WriteLine("");
        Console.WriteLine($"A soma destes dois valores é: { result }");

        Console.ReadKey();
        Menu();
    }

    static void Subtracao() {
        Console.WriteLine("Digite o primeiro valor: ");
        float firstValue = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o primeiro valor: ");
        float secondValue = float.Parse(Console.ReadLine());
        var result =  firstValue - secondValue;
        Console.WriteLine("");
        Console.WriteLine($"A subtração destes dois valores é: { result }");

        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao() {
        Console.WriteLine("Digite o primeiro valor: ");
        float firstValue = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o primeiro valor: ");
        float secondValue = float.Parse(Console.ReadLine());
        var result =  firstValue * secondValue;
        Console.WriteLine("");
        Console.WriteLine($"A multipplicação destes dois valores é: { result }");

        Console.ReadKey();
        Menu();
    }

    static void Divisao() {
        Console.WriteLine("Digite o primeiro valor: ");
        float firstValue = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o primeiro valor: ");
        float secondValue = float.Parse(Console.ReadLine());
        var result =  firstValue / secondValue;
        Console.WriteLine("");
        Console.WriteLine($"A divisão destes dois valores é: { result }");

        Console.ReadKey();
        Menu();
    }

    static void Menu() {
        Console.Clear();
        Console.WriteLine("################################################");
        Console.WriteLine("O que deseja fazer? ");
        Console.WriteLine("[1] - Somar");
        Console.WriteLine("[2] - Subtrair");
        Console.WriteLine("[3] - Multiplicar");
        Console.WriteLine("[4] - Dividir");
        Console.WriteLine("[0] - Sair da Aplicação");
        Console.WriteLine("################################################");

        Console.WriteLine("Digite a opção escolhida: ");
        short funcaoEscolhida = short.Parse(Console.ReadLine());

        switch (funcaoEscolhida) 
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            case 0: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }
}
//Console.ReadLine sempre retorna uma string e não consegue fazer a conversão implicita da string para outro tipo