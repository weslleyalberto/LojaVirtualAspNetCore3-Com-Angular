using LojaVirtual.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaVirtual.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(8);
            builder.Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(50);
           
            builder.Property(p => p.DataPrevisaoEntrega)
                .IsRequired();
            builder.Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(55);
            builder.HasOne(p => p.FormaPagamentos);
               
             builder.Property(p => p.FormaPagamentoId).IsRequired();
            builder.Property(p => p.NumeroEndereco)
                 .IsRequired()
                 .HasMaxLength(5);
            builder.HasOne(p => p.Usuario);
        }
    }
}
