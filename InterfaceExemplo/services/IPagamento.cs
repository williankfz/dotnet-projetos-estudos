using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceExemplo.services
{
    public interface IPagamento
    {
        void Processar(decimal valor);
    }
}