using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceContratos.entities;

namespace InterfaceContratos.services
{
    public class ContractService
    {
        private IOnlinePaymentService _onlinePaymentSerive;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentSerive = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++) {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentSerive.Interest(basicQuota, i);
                double fullQuota =  updatedQuota + _onlinePaymentSerive.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}