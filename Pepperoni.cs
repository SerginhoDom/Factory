namespace DamnFabric;

public class PepperoniPizza : Pizza
{
    private IPizzaIngredientFactory ingredientFactory;

    public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
    {
        this.ingredientFactory = ingredientFactory;
    }

    public override void prepare()
    {
        this.dough = ingredientFactory.CreateDough();
        this.sause = ingredientFactory.CreateSause();
        this.cheese = ingredientFactory.CreateCheese();
        this.clams = ingredientFactory.CreateClams();
    }
}