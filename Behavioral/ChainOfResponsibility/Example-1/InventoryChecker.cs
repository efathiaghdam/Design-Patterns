namespace ChainOfResponsibility.Example_1;

public class InventoryChecker : RequestHandler
{
    public override bool HandleRequest(Product product)
    {
        if (product.ProductName == "ASUS TUF Gaming F15 FX507ZE")
        {
            Console.WriteLine("Məhsul anbarda mövcuddur.");
            return _nextRequestHandler?.HandleRequest(product) ?? true;
        }
        else
        {
            Console.WriteLine("Məhsul anbarda yoxdur.");
            return false;
        }
    }
}
