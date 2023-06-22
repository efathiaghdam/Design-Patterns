namespace ChainOfResponsibility.Example_1;

public class DiscountChecker : RequestHandler
{
    public override bool HandleRequest(Product product)
    {
        if (product.Discount > 0)
        {
            Console.WriteLine("Məhsula endirim var.");
            return _nextRequestHandler?.HandleRequest(product) ?? true;
        }
        else
        {
            Console.WriteLine("Məhsula endirim yoxdur.");
            return false;
        }

    }
}
