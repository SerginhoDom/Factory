using DamnFabric.Ingredients;

namespace DamnFabric;

public class NyPizzaIngredientsFactory : IPizzaIngredientFactory
{
    public Dough CreateDough()
    {
        return new ThinCrustDough();
    }

    public Sause CreateSause()
    {
        return new MarinaraSause();
    }

    public Cheese CreateCheese()
    {
        return new CheddarCheese();
    }

    public IVeggies[] CreateVeggies()
    {
        IVeggies[] veggiesArray = { new Cucumbers(), new Mushrooms(), new Tomato() };
        foreach (var i in veggiesArray)
        {
            i.GetName();
        }
        return veggiesArray;
    }

    public Clams CreateClams()
    {
        return new FreshClams();
    }
}
