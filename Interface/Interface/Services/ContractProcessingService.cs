using System.Text;
using System.Globalization;
using Interface.Entities;

namespace Interface.Services
{
    class ContractProcessingService
    {
        private IPaymentService _paymentService;

        public ContractProcessingService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract)
        {
            StringBuilder s = new StringBuilder();
            double baseAmount = contract.TotalAmount / contract.Months;

            for(int i = 1; i <= contract.Months; i++)
            {
                s.AppendLine($"{contract.Data.AddMonths(i).ToString("dd/MM/yyyy")}: {_paymentService.MonthValue(i, baseAmount).ToString("F2", CultureInfo.InvariantCulture)}");
            }

            System.Console.WriteLine(s.ToString());
        }
    }
}
