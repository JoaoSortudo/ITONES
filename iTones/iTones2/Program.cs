using iTones2;
//codigos estudados anteriormente(Musica, Artista, Albuns, Genero)
#region
Genero reggae = new Genero("Reggae");
Genero punk = new Genero("Punk Rock");
Genero samba = new Genero("Samba");

Artista greenday = new Artista("Green Day", punk);
greenday.Biografia = "Banda Estadunidense de punk rock que eu fui no show";
Artista offspring = new Artista("The Offspring", punk);
offspring.Biografia = "Banda de punk que eu gosto";
Artista marley = new Artista("Bob Marley", reggae);
marley.Biografia = "Melhor artista de Reggae da história";
Artista pixote = new Artista("Pixote", samba);
pixote.Biografia = "Grupo de pagode que é legal";

Album americanIdiot = new Album();
americanIdiot.Nome = "American Idiot";

Musica musica1 = new Musica(greenday, "American Idiot")
{
    Duracao = 174,
    Disponivel = true,
};


Musica musica2 = new Musica(greenday, "Jesus of Suburbia")
{
    Duracao = 548,
    Disponivel = true,
};

americanIdiot.AdicionarMusica(musica1);
americanIdiot.AdicionarMusica(musica2);
greenday.AdicionarAlbum(americanIdiot);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//americanIdiot.ExibirMusicasDoAlbum();
//greenday.ExibirDiscografia();
//greenday.ExibirTodosArtistas();
//Artista.ExibirDadosDoArtista(greenday);
#endregion 

//codigos para o desafio de Podcast e Episodios

Podcast nerdcast = new Podcast("Nerdcast", "Jovem Nerd e Azaghal");

Episodio episodio1 = new Episodio();
episodio1.Titulo = "Regras não ditas da vida.";
episodio1.Duracao = 64;
episodio1.Numero = 1;

Episodio episodio2 = new Episodio();
episodio2.Titulo = "Homem Aranha: Me Leva Pra Casa!";
episodio2.Duracao = 76;
episodio2.Numero = 2;

Episodio episodio3 = new Episodio();
episodio3.Titulo = "A História nos RPGs!";
episodio3.Duracao = 92;
episodio3.Numero = 3;

episodio1.AdicionarConvidados("Sr.K");
episodio2.AdicionarConvidados("Load");
episodio2.AdicionarConvidados("Katiuscha Barcelos");
episodio3.AdicionarConvidados("XadrezVerbal");
episodio3.AdicionarConvidados("Tucano");
episodio3.AdicionarConvidados("Eduardo Spohr");

nerdcast.AdicionarEpisodio(episodio1);
nerdcast.AdicionarEpisodio(episodio2);
nerdcast.AdicionarEpisodio(episodio3);


nerdcast.ExibirDetalhes();