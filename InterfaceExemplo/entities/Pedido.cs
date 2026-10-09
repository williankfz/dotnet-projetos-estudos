using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceExemplo.services;

namespace InterfaceExemplo.entities
{
    public class Pedido
    {
        private readonly IPagamento _pagamento;
        public decimal Valor { get; set; }

        public Pedido(IPagamento pagamento, decimal valor)
        {
            _pagamento = pagamento;
            Valor = valor;
        }

        public void Finalizar()
        {
            _pagamento.Processar(Valor);
        }
    }
}