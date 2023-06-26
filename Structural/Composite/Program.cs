// See https://aka.ms/new-console-template for more information
using Composite.Example_1;

Console.WriteLine("Hello, World!");


Composite.Example_1.Composite root = new Composite.Example_1.Composite("Root");

root.Add(new Leaf("Leaf A"));
root.Add(new Leaf("Leaf B"));

Composite.Example_1.Composite composite = new Composite.Example_1.Composite("Composite X");

composite.Add(new Leaf("Leaf XA"));
composite.Add(new Leaf("Leaf XB"));

root.Add(composite);
root.Add(new Leaf("Leaf C"));

// نمایش ساختار درختی
root.Display(1);

Console.ReadKey();