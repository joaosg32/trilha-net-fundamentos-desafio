using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;
Validacoes validacoes1 = new Validacoes();

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
while (true)
{   
    // Looping que finaliza apenas com a inserção de dados corretos.    
    string precoInicialDigitado = Console.ReadLine();
    if(validacoes1.ValidarPrecoEHora(precoInicialDigitado))
    {
        precoInicial = decimal.Parse(precoInicialDigitado);
        break;
    }
    Console.WriteLine("Entrada inválida, digite novamente.");
    Console.WriteLine("========================================================");
    Console.WriteLine("Digite o preço inicial:");
}

Console.WriteLine("Agora digite o preço por hora:");
while (true)
{
    // Looping que finaliza apenas com a inserção de dados corretos.
    string precoPorHoraDigitado = Console.ReadLine();
    if(validacoes1.ValidarPrecoEHora(precoPorHoraDigitado))
    {
        precoPorHora = decimal.Parse(precoPorHoraDigitado);
        break;
    }
    Console.WriteLine("Entrada inválida, digite novamente.");
    Console.WriteLine("========================================================");
    Console.WriteLine("Digite o preço por hora:");
}
// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);


bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

