
using LojaVirtual.Dominio.Models;
using LojaVirtualAspNetCore3.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaVirtual.Dominio.ObjDeValor
{
   public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool EhBoleto
        {
            get { return Id == (int) TipoFormaPagamentoEnum.Boleto; }
        }
        public bool NaoFoiDenifido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }
        public bool EhCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }
        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }

        
    }
}
