using iTones4.Modelos;
using System.Linq;
namespace iTones4.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
    {
        var artistasPorGenero = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine($"Exibindo os artistas do genero {genero}");

        foreach (var artista in artistasPorGenero)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDoArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);

        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    //pede entrada de ano e exibe as músicas do ano selecionado
    public static void FiltrarMusicasPorAno(List<Musica> musicas, int ano)
    {
        var musicasDoAno = musicas.Where(musica => musica.Ano!.Equals(ano)).ToList();
        Console.WriteLine($"Músicas do ano de {ano}"); 
        foreach (var musica in musicasDoAno)
        {
            Console.WriteLine($"- {musica.Nome}, {musica.Artista}");
        }
    }

    //exibe todas as músicas categorizando por ano de lançamento
    //public static void SepararMusicasPorAno()
    //{

    //}

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tom)
    {
        var musicasPorTom = musicas.Where(musica => musica.Tonalidade.Equals(tom)).ToList();
        Console.WriteLine($"Músicas em {tom}:" +
            $"");

        foreach (var musica in musicasPorTom)
        {
            Console.WriteLine($"- {musica.Nome}, {musica.Artista}");
        }
    }
}
