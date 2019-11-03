using LojaVirtual.Dominio.Interfaces;
using LojaVirtual.Dominio.Models;
using LojaVirtual.Repositorio.Data;

namespace LojaVirtual.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(LojaVirtual3Context context) : base(context)
        {

        }
    }
}
