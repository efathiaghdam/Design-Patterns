namespace Facade.Example_1;

public class AccountingSystem
{
    private Bank bank;
    private Cashier cashier;
    private FinancialService financialService;

    public AccountingSystem()
    {
        bank = new Bank();
        cashier = new Cashier();
        financialService = new FinancialService();
    }

    public bool MakePayment(string accountNumber, string securityCode, double amount)
    {
        bool isPaymentValid = bank.ValidatePayment(accountNumber, securityCode, amount);
        bool isCashAvailable = cashier.CheckCashAvailability(amount);
        bool isInvoiceProcessed = financialService.ProcessInvoice(amount);

        if (isPaymentValid && isCashAvailable && isInvoiceProcessed)
        {
            Console.WriteLine("Payment successfully processed.");
            return true;
        }
        else
        {
            Console.WriteLine("Payment failed.");
            return false;
        }
    }
}
