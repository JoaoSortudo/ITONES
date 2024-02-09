using iTones3.Menus;
using iTones3.Modelos;

Banda kiss = new("Kiss");
kiss.AdicionarNota(new Avaliacao(10));
kiss.AdicionarNota(new Avaliacao(10));
kiss.AdicionarNota(new Avaliacao(10));
kiss.AdicionarAlbum(new Album("Alive!"));


Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(kiss.Nome, kiss);


Dictionary<int, Menus> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuAvaliarBanda());
opcoes.Add(4, new MenuAvaliarAlbum());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(6, new MenuMostrarBandas());
opcoes.Add(0, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"
██╗████████╗░█████╗░███╗░░██╗███████╗░██████╗
██║╚══██╔══╝██╔══██╗████╗░██║██╔════╝██╔════╝
██║░░░██║░░░██║░░██║██╔██╗██║█████╗░░╚█████╗░
██║░░░██║░░░██║░░██║██║╚████║██╔══╝░░░╚═══██╗
██║░░░██║░░░╚█████╔╝██║░╚███║███████╗██████╔╝
╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚══╝╚══════╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao iTones 2.0!");
}

{
    void ExibirOpcoesDoMenu()
    {
        ExibirLogo();
        Console.WriteLine("\nDigite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
        Console.WriteLine("Digite 3 para avaliar uma banda");
        Console.WriteLine("Digite 4 para avaliar um álbum");
        Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
        Console.WriteLine("Digite 6 para mostrar todas as bandas");
        Console.WriteLine("Digite 0 para sair");

        Console.Write("\nDigite a sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
        {
            Menus menuASerExibido = opcoes[opcaoEscolhidaNumerica];
            menuASerExibido.Executar(bandasRegistradas);
            if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine("Opção inválida"); 
            Console.WriteLine("\nDigite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }
    ExibirOpcoesDoMenu();
}