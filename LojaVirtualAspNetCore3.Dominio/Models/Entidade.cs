using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LojaVirtual.Dominio.Models
{
   public abstract class Entidade
    {
        private List<string> _Mensagem { get; set; }
        private List<string> MensagemValidacao 
        {
            get { return _Mensagem ?? (_Mensagem = new List<string>()); }
        }
        public abstract void Validate();
        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }
        protected void LimparMensagemValidacao()
        {
            MensagemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }
    }
}
