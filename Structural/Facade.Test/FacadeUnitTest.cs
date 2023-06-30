using Facade.Example_1;

namespace Facade.Test;

public class FacadeUnitTest
{
    [Fact]
    public void MakePayment_ValidPayment_ReturnsTrue()
    {
        // Arrange
        AccountingSystem accountingSystem = new AccountingSystem();

        // Act
        bool paymentResult = accountingSystem.MakePayment("1234567890", "1234", 1000.0);

        // Assert
        Assert.True(paymentResult, "Payment should be successful");
    }

    [Fact]
    public void MakePayment_InvalidPayment_ReturnsFalse()
    {
        // Arrange
        AccountingSystem accountingSystem = new AccountingSystem();

        // Act
        bool paymentResult = accountingSystem.MakePayment("0987654321", "5678", 5000.0);

        // Assert
        Assert.False(paymentResult, "Payment should fail");
    }
}