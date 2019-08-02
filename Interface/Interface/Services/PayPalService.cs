namespace Interface.Services
{
    class PaypalService : IPaymentService
    {
        private double interest = 0.01;
        private double tax = 0.02;

        public double MonthValue(int month, double baseAmount)
        {
            double quota = baseAmount + ((baseAmount * interest) * month);
            return quota + (quota * tax);
        }
    }
}
