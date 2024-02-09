using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTones2
{
    public class Genero
    {
        public Genero(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; }
        public string Descricao { get; set; }
        
        public List<Artista> artistasDoGenero = new List<Artista>();

    }

}
