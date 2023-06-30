using Facade.Example_1;

// Facade class: AccountingSystem
AccountingSystem accountingSystem = new AccountingSystem();

// Easier access to subsystems using Facade Pattern
bool paymentResult = accountingSystem.MakePayment("1234567890", "1234", 1000.0);
if (paymentResult)
    Console.WriteLine("Payment was successful.");
else
    Console.WriteLine("Payment failed.");

Console.ReadLine();