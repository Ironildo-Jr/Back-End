using Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Produtos")]
    public class Produto
    {
        private static BdContext bd = new BdContext();
        
        public Produto() { }
        public Produto(int id, string descr, int preco)
        {
            this.Id = id;
            this.Descricao = descr;
            this.Preco = preco;
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Preco { get; set; }
        
        public static List<Produto> Produtos()
        {
            return bd.Produtos.ToList();
        }

    }
}