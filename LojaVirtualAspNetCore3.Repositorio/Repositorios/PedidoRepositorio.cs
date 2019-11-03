using LojaVirtual.Dominio.Interfaces;
using LojaVirtual.Dominio.Models;
using LojaVirtual.Repositorio.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaVirtual.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(LojaVirtual3Context context) : base(context)
        {
        }
    }
}
