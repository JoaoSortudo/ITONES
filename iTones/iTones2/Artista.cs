using iTones2;

public class Artista
{
    private List<Album> albums = new List<Album>();
    public static List<Artista> ListaDeArtistas { get; } = new List<Artista>();
    public string Nome { get; }
    public Genero genero { get; }

    public string Biografia { get; set; }
    public Artista(string nome, Genero genero)
    {
        Nome = nome;
        ListaDeArtistas.Add(this);
    }

    public void AdicionarGenero(Genero genero)
    {

    }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia do artista: {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
        }
    }

    public void ExibirTodosArtistas()
    {
        int contador = 0;
        foreach (Artista artista in ListaDeArtistas)
        {
            contador++;
            Console.WriteLine($"Artista {contador}: {artista.Nome}");
        }
    }

    public void ExibirDadosDoArtista(Artista artista)
    {
        Console.WriteLine($"{artista.Nome}\n{artista.genero}\n{artista.Biografia}");
        artista.ExibirDiscografia();
    }
}