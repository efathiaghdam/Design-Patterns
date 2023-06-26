namespace Composite.Example_1;

public class Leaf : Component
{
    public Leaf(string name) : base(name)
    {
        
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);
    }
}
