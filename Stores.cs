namespace DamnFabric;

    public class ChicagoPizzaStore : PizzaStore
{
    public override Pizza createPizza(String type)
    {
        Pizza piza = null;
        IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientsFactory();

        if (type.Equals("cheese"))
        {
            piza = new CheesePizza(ingredientFactory);
        }
        else if (type.Equals("pepperoni"))
        {
            piza = new PepperoniPizza(ingredientFactory);
        }
        else if (type.Equals("greek"))
        {
            piza = new GreekPizza(ingredientFactory);
        }
        return piza;
    }
}


public class NyPizzaStore : PizzaStore
{
    public override Pizza createPizza(String type)
    {
        Pizza piza = null;
        IPizzaIngredientFactory ingredientFactory = new NyPizzaIngredientsFactory();

        if (type.Equals("cheese"))
        {
            piza = new CheesePizza(ingredientFactory);
        }
        else if (type.Equals("pepperoni"))
        {
            piza = new PepperoniPizza(ingredientFactory);
        }
        return piza;
    }
}