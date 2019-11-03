using LojaVirtual.Dominio.Interfaces;
using LojaVirtual.Dominio.Models;
using LojaVirtual.Repositorio.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaVirtual.Repositorio.Repositorios
{
   public class UsuarioRepositorio : BaseRepositorio<Usuario> , IUsuarioRepositorio
    {
        public UsuarioRepositorio(LojaVirtual3Context context) : base(context)
        {

        }
    }
}
