using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceNotificacaoPedido.Services
{
    public class EmailNotificador : INotificador
    {
        public void Enviar(string? mensagem)
        {
            Console.WriteLine($"A mensagem {mensagem} foi enviada pelo e-mail");
        }
    }
}