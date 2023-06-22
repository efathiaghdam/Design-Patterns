namespace ChainOfResponsibility.Example_1;

/// <summary>
/// کلاس پردازش زنجیره
/// </summary>
public abstract class RequestHandler
{
    protected RequestHandler _nextRequestHandler;

    public void SetNextHandler(RequestHandler requestHandler)
    {
        _nextRequestHandler = requestHandler;
    }

    public abstract bool HandleRequest(Product product);
}
