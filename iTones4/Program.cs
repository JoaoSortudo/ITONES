using iTones4.Modelos;
using System.Text.Json;
using iTones4.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[27].ExibirDetalhesDaMusica();
        musicas[32].ExibirDetalhesDaMusica();

        #region
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGenero(musicas, "latin");
        //LinqFilter.FiltrarMusicasDoArtista(musicas, "Michael Jackson");
        //LinqFilter.FiltrarMusicasPorAno(musicas, 2012);
        //LinqFilter.FiltrarMusicasPorTonalidade(musicas, "F");

        //var preferidasJoao = new MusicasPreferidas("João");
        //preferidasJoao.AdicionarMusicasFavoritas(musicas[9]);
        //preferidasJoao.AdicionarMusicasFavoritas(musicas[14]);
        //preferidasJoao.AdicionarMusicasFavoritas(musicas[81]);
        //preferidasJoao.AdicionarMusicasFavoritas(musicas[87]);
        //preferidasJoao.AdicionarMusicasFavoritas(musicas[1902]);

        //preferidasJoao.ExibirMusicasFavoritas();

        //var preferidasIri = new MusicasPreferidas("Iris");
        //preferidasIri.AdicionarMusicasFavoritas(musicas[14]);
        //preferidasIri.AdicionarMusicasFavoritas(musicas[27]);
        //preferidasIri.AdicionarMusicasFavoritas(musicas[1895]);
        //preferidasIri.AdicionarMusicasFavoritas(musicas[9]);
        //preferidasIri.AdicionarMusicasFavoritas(musicas[20]);

        //preferidasIri.ExibirMusicasFavoritas();
        //preferidasIri.GerarArquivoJson();
        #endregion
    }

    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}