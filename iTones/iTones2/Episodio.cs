using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTones2
{
    public class Episodio
    {
        private List<string> convidados = new List<string>();

        //criar o ctor para criar as propriedades junto com o episodio!
        public int Numero { get; set; }
        public string Titulo { get; set; }

        public int Duracao { get; set; }

        public string Resumo => $"{Numero}. {Titulo} (Duração: {Duracao} minutos) - {string.Join(", ", convidados)}";
        public void AdicionarConvidados(string convidado)
        {
            convidados.Add(convidado);
        }
    }

}
