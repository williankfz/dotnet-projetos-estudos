using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceNotificacaoPedido.Services
{
    public interface INotificador
    {
        void Enviar(string? mensagem);
    }
}