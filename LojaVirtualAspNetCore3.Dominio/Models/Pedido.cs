using LojaVirtual.Dominio.ObjDeValor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LojaVirtual.Dominio.Models
{
   public class Pedido : Entidade
    {
        public int Id { get; set; }
       
        private readonly DateTime _datapedido = DateTime.Today;
        public DateTime DataPedido
        {
            get { return _datapedido; }
           
        }

        public int  UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento  FormaPagamentos { get; set; }
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (!ItensPedido.Any())
                AdicionarCritica("Crítica - Pedido não pode ficar vazio");
            if(string.IsNullOrWhiteSpace(CEP))
            AdicionarCritica("Crítica - O Campo CEP não pode ficar vazio ou conter espaços!");
        }
    }
}
