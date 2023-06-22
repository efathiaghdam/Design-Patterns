﻿namespace ChainOfResponsibility.Example_1;

// در این مثال قصد داریم یک سیستم مدیریت خرید آنلاین را در فروشگاه آنلاین که درخواست های خرید از طریق یک زنجیزه ای از شی هاپردازش شود.
// سناریوهای که قرار هست در سیستم پیاده سازی شود.
// 1- بررسی موجودی : یعنی اینکه آیا محصول در انبار موجود می باشد یا خیر. اگر محصول موجود بود درخواست ما به شی بعدی منتقل می شود در غیر این صورت درخواست ما متوقف شده و پیغام خطا خواهد داد.
// 2- بررسی قیمت : در این سناریو به بررسی قیمت می پردازیم که آیا قیمت محصول زیر 100 دلار هست یا خیر اگر کمتر از 100 دلار بود به درخواست بعدی منتقل می شود در غیر این صورت درخواست متوقف شده و پیام خطا صادر خواهد کرد
// 3- بررسی تخفیف : در این سناریو می خواهیم که محصولات حتما تخفیف داشته باشند اگر محصولی تخفیف نداشته باشد پیام خطا صادر خواهد شد در غیر خرید انجام خواهد شد.


/// <summary>
/// کلاس درخواست محصول
/// </summary>
public class Product
{
    public string ProductName { get; private set; }
    public decimal Price { get; private set; }
    public decimal Discount { get; private set; }

    public Product(string productName, decimal price, decimal discount)
    {
        ProductName = productName;
        Price = price;
        Discount = discount;
    }
}