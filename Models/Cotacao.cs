using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Cotacoes")]
    public class Cotacao
    {
        public Cotacao() { }
        public Cotacao(int id, string data, string hora)
        {
            this.Id = id;
            this.Data = data;
            this.Hora = hora;
        }
        public int Id { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public List<CotacaoForn> FornecedoresCot { get; set; }
        public List<CotacaoProd> ProdutosCot { get; set; }
    }
}
