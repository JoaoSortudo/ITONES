
using System.Runtime.CompilerServices;


using Spotify_de_Caô;
using static Spotify_de_Caô.Testejogo;


string msgBemVindo = @"
████████████████████████████████████
█▄─▄█─▄─▄─█─▄▄─█▄─▀█▄─▄█▄─▄▄─█─▄▄▄▄█
██─████─███─██─██─█▄▀─███─▄█▀█▄▄▄▄─█
▀▄▄▄▀▀▄▄▄▀▀▄▄▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀ 


Boas vindas ao iTones!
";

//List<string> listaDeArtistas = new List<string> {"Mumuzinho", "Ludmilla", "Bob Marley", "Ms. Lauryn Hill", "Tekno"};

Dictionary<string, List<int>> artistasRegistrados = new Dictionary<string, List<int>>();
artistasRegistrados.Add("Racionais", new List<int> { 10, 8, 6 });
artistasRegistrados.Add("The Killers", new List<int>());


void ExibirLogo(string msg)
{
    Console.WriteLine(msg);
}
void ExibirMenu()
{
    ExibirLogo(msgBemVindo);
    Console.WriteLine(" Digite 1 para registrar um artista\n Digite 2 para mostrar todos os artistas\n Digite 3 para avaliar um artista\n Digite 4 para exibir a media de um artista \n Digite 0 para sair...");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    #region
    //if (opcaoEscolhidaNumerica == 1)
    //{
    //    Console.WriteLine("\nQual banda você quer registrar?");
    //}
    //else if (opcaoEscolhidaNumerica == 2)
    //{
    //    Console.WriteLine("\nAqui estão as bandas: ");
    //}
    //else if (opcaoEscolhidaNumerica == 3)
    //{
    //    Console.WriteLine("\nDê uma nota de 1 a 5 para a banda selecionada: ");
    //}
    //else if (opcaoEscolhidaNumerica == 4)
    //{
    //    Console.WriteLine("\nAqui está a média da bbanda selecionada: ");
    //}
    //else if (opcaoEscolhidaNumerica == 0)
    //{
    //    Console.WriteLine("\nAté a próxima!");
    //}
    //else
    //{
    //    Console.WriteLine("Por favor, escolha uma opção válida.");
    //    ExibirMenu();
    //}
    #endregion

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarArtista(); break;
        case 2: MostrarArtistas(); break;
        case 3: AvaliarArtista(); break;
        case 4: MediaArtista(); break;
        case 0: Console.WriteLine("Até a próxima!"); break;
        default:
            Console.WriteLine("Escolha uma opção válida.");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirMenu(); break;
    }

}

void RegistrarArtista()
{
    Console.Clear();
    Console.WriteLine("Registro de artistas");
    Console.Write("Digite o nome do artista que deseja registrar: ");
    string nomeDoArtista = Console.ReadLine()!;
    artistasRegistrados.Add(nomeDoArtista, new List<int>());
    Console.WriteLine($"O artista {nomeDoArtista} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void MostrarArtistas()
{
    Console.Clear();
    Console.WriteLine("Exibindo todos os artistas registrados:");
    //for (int i = 0; i < listaDeArtistas.Count; i++)
    //{
    //    Console.WriteLine($"Artista: {listaDeArtistas[i]}");
    //}
    foreach (string artista in artistasRegistrados.Keys)
    {
        Console.WriteLine($"Artista: {artista}");
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void AvaliarArtista()
{
    //1 - qual banda avaliar?


    //2 - se a banda existir no dicionário >> dar uma nota.


    //3 - se não, volta ao menu principal

    Console.Clear();
    Console.WriteLine("Avalie o artista!");
    Console.Write("Digite o nome do artista que deseja avaliar: ");
    string nomeDoArtista = Console.ReadLine()!;
    if (artistasRegistrados.ContainsKey(nomeDoArtista))
    {
        Console.Write($"Digite qual a nota que {nomeDoArtista} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        artistasRegistrados[nomeDoArtista].Add(nota);
        Console.WriteLine($"Você avaliou {nomeDoArtista} com nota {nota}!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nO artista {nomeDoArtista} não existe na biblioteca.");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

void MediaArtista()
{
    Console.Clear();
    Console.Write("De qual artista você deseja saber a média de notas? Digite ao lado: ");
    string artista = Console.ReadLine()!;

    if (artistasRegistrados.ContainsKey (artista))
    {
        double mediaArtista = artistasRegistrados[artista].Average();
        Console.WriteLine($"\nA nota média de {artista} é {mediaArtista}");
    }
    else
    {
        Console.WriteLine($"\nO artista {artista} não existe na biblioteca.");
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

ExibirMenu();