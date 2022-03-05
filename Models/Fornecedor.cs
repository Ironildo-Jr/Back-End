using System.ComponentModel.DataAnnotations.Schema;

namespace Models{
    [Table("Fornecedores")]
    public class Fornecedor{
        public Fornecedor() { }
        public Fornecedor(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
        public int Id{ get; set; }
        public string Nome{ get; set; }
    }
}