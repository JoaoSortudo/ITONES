
using iTones2;
using System.Runtime.CompilerServices;

public class Musica
{
    public Musica(Artista artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Artista Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }


    public string DescricaoResumida => $"A música {Nome} pertence ao artista {Artista}"; 
    public void ExibirFichaTecnica()
    {
        
        if (Disponivel == true)
        {
            Console.WriteLine($"Nome/Artista: {Nome} - {Artista.Nome}.\nDuração: {Duracao} minutos.");
            Console.WriteLine("Disponível para ouvir!");
        }
        else { Console.WriteLine($"Nenhum resultado para {Nome}");}
    }
}

