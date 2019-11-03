using JetBrains.Annotations;
using LojaVirtual.Dominio.Models;
using LojaVirtual.Dominio.ObjDeValor;
using LojaVirtual.Repositorio.Config;
using Microsoft.EntityFrameworkCore;

namespace LojaVirtual.Repositorio.Data
{
    public class LojaVirtual3Context : DbContext
    {
       
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento>  FormaPagamento { get; set; }
        public LojaVirtual3Context(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //CLASSES DE MAPEAMENTO
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(new FormaPagamento()
            {
                Id = 1,
                Nome = "Boleto",
                Descricao = "Pagamento atraves de Boleto Bancário"



            }, new FormaPagamento()
            {
                Id = 2, Nome = "Cartão de Crédito", Descricao = "Pagamento Parcelado através dos cartões de Crédito"
            },
            new FormaPagamento()
            {
                Id = 3,
                Nome = "Deposito",
                Descricao = "Pagamento através de Deposito Bancário"
            }

            ) ;
            base.OnModelCreating(modelBuilder);

        }
    }
}
