namespace Composite.Example_1;

public class Composite : Component
{
    List<Component> Components = new List<Component>();

    public Composite(string name) : base(name)
    {

    }

    public void Add(Component component)
    {
        Components.Add(component);
    }

    public void Remove(Component component)
    { 
        Components.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);

        foreach (Component component in Components)
        {
            component.Display(depth + 2);
        }
    }
}
