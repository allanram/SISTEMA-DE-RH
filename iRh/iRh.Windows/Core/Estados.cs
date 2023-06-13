using System.Collections.Generic;

namespace iRh.Windows.Core
{
    public class Estados
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public List<Estados> ObterTodosEstados()
        {
            var listaDeEstados = new List<Estados>();
            listaDeEstados.Add(new Estados { Id = 11, Nome = "Rondonia", Sigla = "RO" });
            listaDeEstados.Add(new Estados { Id = 12, Nome = "Acre", Sigla = "AC" });
            return listaDeEstados;

        }
    }
}
