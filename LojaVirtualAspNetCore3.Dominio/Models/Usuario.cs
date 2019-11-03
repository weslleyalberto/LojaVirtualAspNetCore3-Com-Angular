using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LojaVirtual.Dominio.Models
{
   public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        //UM USUARIO PODE TER NENHUM OU VÁRIOS PEDIDOS
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
           
                LimparMensagemValidacao();
                if (string.IsNullOrWhiteSpace(Email))
                    AdicionarCritica("Email não informado ou há espaços entre as email digitado");
                if (string.IsNullOrWhiteSpace(Senha))
                    AdicionarCritica("O preenchiento da Senha e obrigatório");
            
        }
    }
}
