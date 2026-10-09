using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceContratos.services
{
    public interface IOnlinePaymentService
    {
        double PaymentFee(double amount);

        double Interest(double amount, int months);
    }
}