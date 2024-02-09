using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTones2
{
    public class Podcast
    {   
        public List<Episodio> episodios = new List<Episodio>();
        public string Nome { get;}
        public string Host { get; }
        public int TotalEpisodios => episodios.Count;
        public Podcast(string nome, string host)
        {
            Nome = nome;
            Host = host;
        }

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            int contador = 0;

            Console.WriteLine($"Boas vindas ao podcast {Nome}, apresentado por {Host}.\n");
            
            Console.WriteLine($"Lista de episódios de {Nome}:\n");
            
            foreach (Episodio episodio in  episodios.OrderBy(e => e.Numero))
            {
                contador++;
                Console.WriteLine(episodio.Resumo);
            }

            Console.WriteLine($"\n{TotalEpisodios} episódios.");
        }
    }
}
