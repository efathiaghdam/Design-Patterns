namespace Facade.Example_1;

public class Bank
{
    public bool ValidatePayment(string accountNumber, string securityCode, double amount)
    {
        Console.WriteLine("Validating payment...");

        // logic

        if(accountNumber != "1234567890")
            return false;

        if(amount > 1000.0)
            return false;

        return true;
    }
}
