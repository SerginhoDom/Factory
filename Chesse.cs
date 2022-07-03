namespace DamnFabric;

public class CheesePizza : Pizza
{
    private IPizzaIngredientFactory ingredientFactory;

    public CheesePizza(IPizzaIngredientFactory ingredientFactory)
    {
        this.ingredientFactory = ingredientFactory;
    }

    public override void prepare()
    {
        this.dough = ingredientFactory.CreateDough();
        this.sause = ingredientFactory.CreateSause();
        this.cheese = ingredientFactory.CreateCheese();
    }
}