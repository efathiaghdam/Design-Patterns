namespace ChainOfResponsibility.Example_1;

public class PriceChecker : RequestHandler
{
    public override bool HandleRequest(Product product)
    {
        if (product.Price <= 100)
        {
            Console.WriteLine("Məhsulun qiyməti 100 dollardan aşağı və ya ona bərabərdir.");
            return _nextRequestHandler?.HandleRequest(product) ?? true;
        }
        else
        {
            Console.WriteLine("Məhsulun qiyməti 100 dollardan yuxarıdır.");
            return false;
        }
    }
}
