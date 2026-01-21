// Screen Sound
using System.Reflection.Metadata;

string mensagemDeBoasVindas = "Boas vindas ao MusicConsole";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Beatles", new List<int> {10, 9, 2, 6 });
bandasRegistradas.Add("U2", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
████████████████████████████████████████████████████████████████████████████
█▄─▀█▀─▄█▄─██─▄█─▄▄▄▄█▄─▄█─▄▄▄─███─▄▄▄─█─▄▄─█▄─▀█▄─▄█─▄▄▄▄█─▄▄─█▄─▄███▄─▄▄─█
██─█▄█─███─██─██▄▄▄▄─██─██─███▀███─███▀█─██─██─█▄▀─██▄▄▄▄─█─██─██─██▀██─▄█▀█
▀▄▄▄▀▄▄▄▀▀▄▄▄▄▀▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▄▀▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀
    ");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a média de uma banda.");
    Console.WriteLine("Digite -1 para sair.");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBandas();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirMedia();
            break;
        case -1:
            Console.WriteLine("Obrigado e até a próxima! xD");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Bandas registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite qualquer  tecla para retornar ao menu inicial.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao (string titulo)
{
    int qtdLetras = titulo.Length;
    string separator = string.Empty.PadLeft(qtdLetras, '~');
    Console.WriteLine(separator);
    Console.WriteLine(titulo);
    Console.WriteLine(separator + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota a banda '{nomeDaBanda}' merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota para a banda {nomeDaBanda} foi registrada com sucesso.");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"\nA banda '{nomeDaBanda}' não foi encontrada !");
        Console.WriteLine("\nDigite qualquer  tecla para retornar ao menu inicial.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}
void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda para exibir a nota média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"\nA nota média da banda é: {bandasRegistradas[nomeDaBanda].Average()}.");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda '{nomeDaBanda}' não foi encontrada !");
        Console.WriteLine("\nDigite qualquer  tecla para retornar ao menu inicial.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}
ExibirOpcoesDoMenu();