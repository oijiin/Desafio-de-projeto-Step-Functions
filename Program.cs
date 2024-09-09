using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone smartphone = null;
bool sair = false;

while (!sair)
{
    Console.WriteLine("Bem-vindo ao menu de smartphones!");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Criar um smartphone Nokia");
    Console.WriteLine("2 - Criar um smartphone iPhone");
    Console.WriteLine("3 - Sair");
    Console.Write("Digite o número da opção desejada: ");
    string opcao = Console.ReadLine().Trim();

    switch (opcao)
    {
        case "1":
            smartphone = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
            Console.WriteLine("\nSmartphone Nokia criado.");
            ExibirOpcoes(smartphone);
            break;

        case "2":
            smartphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "222222222", memoria: 128);
            Console.WriteLine("\nSmartphone iPhone criado.");
            ExibirOpcoes(smartphone);
            break;

        case "3":
            sair = true;
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }

    Console.WriteLine("\n");
}

void ExibirOpcoes(Smartphone smartphone)
{
    bool continuar = true;

    while (continuar)
    {
        Console.WriteLine("\nO que você deseja fazer?");
        Console.WriteLine("1 - Ligar");
        Console.WriteLine("2 - Receber Ligação");
        Console.WriteLine("3 - Instalar Aplicativo");
        Console.WriteLine("4 - Voltar ao menu principal");
        Console.Write("Digite o número da opção desejada: ");
        string opcao = Console.ReadLine().Trim();

        switch (opcao)
        {
            case "1":
                smartphone.Ligar();
                break;

            case "2":
                smartphone.ReceberLigacao();
                break;

            case "3":
                Console.Write("Digite o nome do aplicativo para instalar: ");
                string app = Console.ReadLine().Trim();
                smartphone.InstalarAplicativo(app);
                break;

            case "4":
                continuar = false;
                break;

            default:
                Console.WriteLine("Opção inválida, tente novamente.");
                break;
        }
    }
}