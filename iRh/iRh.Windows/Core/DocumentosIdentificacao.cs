using System.Collections.Generic;
namespace iRh.Windows.Core
{
    public  class DocumentosIdentificacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<DocumentosIdentificacao> ObterTodosDocumentos()
        {
            var listaDeDocumentos = new List<DocumentosIdentificacao>();
            listaDeDocumentos.Add(new DocumentosIdentificacao { Id = 1, Descricao = "Registro Geral" });
            listaDeDocumentos.Add(new DocumentosIdentificacao { Id = 2, Descricao = "Carteira Nacional de Habilitação" });
            listaDeDocumentos.Add(new DocumentosIdentificacao { Id = 3, Descricao = "Passaporte" });
            listaDeDocumentos.Add(new DocumentosIdentificacao { Id = 4, Descricao = "Carteira de Trabalho" });
            listaDeDocumentos.Add(new DocumentosIdentificacao { Id = 5, Descricao = "Certificado de Reservista" });
            return listaDeDocumentos;

        }

    } 
}
