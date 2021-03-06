﻿using LojaVirtual.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaVirtual.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(400);
            builder.Property(p => p.Preco)
                .IsRequired();
           
        }
    }
}
