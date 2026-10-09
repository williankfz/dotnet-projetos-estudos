using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceNotificacaoPedido.Services;

namespace InterfaceNotificacaoPedido.Entities
{
    public class Pedido
    {
        private INotificador _notificador;
        public string? Nome { get; set; }

        public Pedido(string? nome, INotificador notificador)
        {
            Nome = nome;
            _notificador = notificador;
        }

        public string Finalizar()
        {
            return $"Pedido finalizado";
        }
    }
}