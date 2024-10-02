public static class OrderManager
{
    public static Order CreateOrder(Customer[] customers, Pizza[] pizzas, Topping[] toppings)
    {
        Random rnd = new Random();
        Customer customer = customers[rnd.Next(customers.Length)];
        Pizza pizza = pizzas[rnd.Next(pizzas.Length)];
        Topping topping = toppings[rnd.Next(toppings.Length)];

        return new Order(customer, pizza, topping);
    }
}
