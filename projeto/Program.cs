using ProjetoEstacionamento.Models;

// Encoding UTF8
Console.OutputEncoding = System.Text.Encoding.UTF8;


decimal precoInical = 0;
decimal precoPorHora = 0;

Console.WriteLine("seja bem vindo ao sistema de estacionamento! \n" + 
                    "Digite o preço inicial:");
precoInical = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());


//Instanciando a classe Estacionamento
Estacionamento es = new Estacionamento(precoInical, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo ");
    Console.WriteLine("3 - Listar  veículos");
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
Console.WriteLine("O programa se encerrou ! Obrigado pela preferência ");