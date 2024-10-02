var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var customers = Data.Customers;
var pizzas = Data.Pizzas;
var toppings = Data.Toppings;



app.MapGet("/", () => "Hello World!");


app.MapGet("/order", () =>

{
    var order = OrderManager.CreateOrder(customers, pizzas, toppings);
    return Results.Json(order);

});


app.Run();










