using Composite.Example_1;

namespace Composite.Test;

public class CompositeTest
{
    [Fact]
    public void TestComposition()
    {
        Composite.Example_1.Composite root = new Example_1.Composite("Root");
        root.Add(new Leaf("Leaf A"));
        root.Add(new Leaf("Leaf B"));

        Example_1.Composite composite = new Example_1.Composite("Composite X");
        composite.Add(new Leaf("Leaf XA"));
        composite.Add(new Leaf("Leaf XB"));

        root.Add(composite);
        root.Add(new Leaf("Leaf C"));

        // اعتبارسنجی ساختار درختی با استفاده از تست واحد
        Console.WriteLine("Running unit test for Composite pattern...");

        Console.WriteLine("Expected Output:");
        Console.WriteLine("- Root");
        Console.WriteLine("-- Leaf A");
        Console.WriteLine("-- Leaf B");
        Console.WriteLine("-- Composite X");
        Console.WriteLine("--- Leaf XA");
        Console.WriteLine("--- Leaf XB");
        Console.WriteLine("-- Leaf C");

        Console.WriteLine();
        Console.WriteLine("Actual Output:");
        root.Display(1);

        Console.WriteLine();
        Console.WriteLine("Unit test completed.");

    }



}