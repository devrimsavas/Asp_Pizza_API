
public class Order
{
    public Customer Customer { get; set; }
    public Pizza Pizza { get; set; }
    public Topping Topping { get; set; }
    public decimal TotalPrice { get; set; }

    public string? Status { get; set; }
    public DateTime OrderTime { get; set; }

    public Order(Customer customer, Pizza pizza, Topping topping)
    {
        Customer = customer;
        Pizza = pizza;
        Topping = topping;
        TotalPrice = pizza.Price + topping.Price;
        OrderTime = DateTime.Now;
        //status default ordered 
        Status = "ordered";

    }

    // Display order details
    public void DisplayOrder()
    {
        Console.WriteLine($"Customer: {Customer.Name}");
        Console.WriteLine($"Pizza: {Pizza.Name}, Price: {Pizza.Price:C}");
        Console.WriteLine($"Topping: {Topping.Name}, Price: {Topping.Price:C}");
        Console.WriteLine($"Total Price: {TotalPrice:C}");
        Console.WriteLine($"Order Status: {Status}");
        Console.WriteLine($"Order Time: {OrderTime}");
        Console.WriteLine("--------------");
    }
}
