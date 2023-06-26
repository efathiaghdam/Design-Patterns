namespace Composite.Example_1;

public abstract class Component
{
    protected string Name { get; private set; }

    public Component(string name)
    {
        Name = name;
    }

    public abstract void Display(int depth);
}
