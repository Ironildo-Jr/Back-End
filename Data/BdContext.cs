using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class BdContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Cotacao> Cotacoes { get; set; }
        public DbSet<CotacaoForn> CotacoesForns { get; set; }
        public DbSet<CotacaoProd> CotacoesProds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=Conceito;User Id=postgres;Password=admin;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CotacaoForn>()
                .HasKey(e => new { e.CotId, e.FornId });

            modelBuilder.Entity<CotacaoProd>()
                .HasKey(e => new { e.CotId, e.ProdId });
        }

    }
}