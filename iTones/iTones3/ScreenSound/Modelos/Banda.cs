using OpenAI_API;

namespace iTones3.Modelos;
internal class Banda : IAvaliavel
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(string nome)
    {
        Nome = nome;
        var client = new OpenAIAPI("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");

        var chat = client.Chat.CreateConversation();

        chat.AppendSystemMessage($"Resuma a banda {nome} em um parágrafo. Adote um estilo informal.");

        string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        Resumo = resposta;
    }

    public string Nome { get; }
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public IEnumerable<Album> Albuns => albuns;

    public string? Resumo { get; set; }

    public void AdicionarAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}