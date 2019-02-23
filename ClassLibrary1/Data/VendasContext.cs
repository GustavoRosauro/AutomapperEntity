using EntityAutomap.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityAutomap.Data
{
    public class VendasContext:DbContext
    {
        public VendasContext()
            :base("Vendas"){}
        public DbSet<ProdutoDto> Produtos { get; set; }
        public DbSet<PedidoDto> Pedidos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PedidoDto>()
            .HasOptional(x => x.Produto).WithMany().HasForeignKey(x=> x.IdProduto);
            base.OnModelCreating(modelBuilder);
        }
    }    
}