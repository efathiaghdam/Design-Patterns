
using ChainOfResponsibility.Example_1;

Console.WriteLine("Example-1");

// ایجاد شی های مربوط به کلاس های پردازش زنجیره ای خرید محصول
var inventoryChecker = new InventoryChecker();
var priceChecker = new PriceChecker();
var discountChecker = new DiscountChecker();

// تعیین ترتیب زنجیره
inventoryChecker.SetNextHandler(priceChecker);
priceChecker.SetNextHandler(discountChecker);

// ساختن یک محصول برای پردازش درخواست
var product = new Product("ASUS TUF Gaming F15 FX507ZE", 99, 2);

var result = inventoryChecker.HandleRequest(product);

if (result)
{
    Console.WriteLine("success");
}
else
    Console.WriteLine("failed");

Console.ReadLine();
