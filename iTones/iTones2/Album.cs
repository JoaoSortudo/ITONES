public class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de musicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine(musica.Nome);
        }
        Console.WriteLine($"Duração do álbum: {DuracaoTotal} segundos.");
    }
}