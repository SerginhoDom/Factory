namespace DamnFabric;

public class test
{
    static void Main(string[] arg)
    {
        ChicagoPizzaStore chicagoPizzaStore = new ChicagoPizzaStore();
        NyPizzaStore nyPizzaStore = new NyPizzaStore();

        nyPizzaStore.orderPizza("pepperoni");
    }
}