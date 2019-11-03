﻿using LojaVirtual.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaVirtual.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);


            //builder utiliza padrão fluent
            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);
            builder.Property(u => u.SobreNome)
                .HasMaxLength(100)
                .IsRequired();
            builder.HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);
                
                

        }
    }
}
