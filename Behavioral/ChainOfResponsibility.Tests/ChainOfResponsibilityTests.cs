namespace ChainOfResponsibility.Tests;

public class ChainOfResponsibilityTests
{
    [Fact]
    public void Given_ProductAvailable_When_HandleRequest_Then_PassesToNextHandler()
    {
        // Arrange
        var inventoryChecker = new InventoryChecker();
        var priceChecker = new PriceChecker();
        var discountChecker = new DiscountChecker();
        inventoryChecker.SetNextHandler(priceChecker);
        priceChecker.SetNextHandler(discountChecker);

        var request = new Product("ASUS TUF Gaming F15 FX507ZE", 80, 10);


        // Act
        var result = inventoryChecker.HandleRequest(request);

        // Assert
        // درخواست باید به پردازشگر بعدی (PriceChecker) منتقل شود
        Assert.True(result);
        Assert.True(priceChecker.HandleRequest(request));
    }

    [Fact]
    public void InventoryChecker_HandleRequest_ProductNotAvailable_StopsProcessing()
    {
        // Arrange
        var inventoryChecker = new InventoryChecker();
        var priceChecker = new PriceChecker();
        var discountChecker = new DiscountChecker();
        inventoryChecker.SetNextHandler(priceChecker);
        priceChecker.SetNextHandler(discountChecker);

        var request = new Product("product", 80, 10);

        // Act
        var result = inventoryChecker.HandleRequest(request);

        // Assert
        // پردازش باید متوقف شود و درخواست باید به پردازشگر بعدی منتقل نشود

        Assert.False(result);
    }
}