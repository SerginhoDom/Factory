using DamnFabric.Ingredients;

namespace DamnFabric;

public abstract class Pizza
{
    String name;
    protected Dough dough;
    protected Sause sause;
    protected IVeggies[] veggies;
    protected Clams clams;
    protected Cheese cheese;

    public abstract void prepare();

    public void bake()
    {
        Console.WriteLine("WZH");
    }

    public void cut()
    {
        Console.WriteLine("Slice");
    }

    public void box()
    {
        Console.WriteLine("SHKR");
    }
}