# Pizza Order API - ASP.NET Core

This is a simple ASP.NET Core web API that generates random pizza orders, including customer, pizza, and topping information. The project is designed to simulate a restaurant order system where users can fetch random orders via API endpoints.

## Features

- Generate random pizza orders with customer details, pizza types, and toppings.
- API returns order information in JSON format.
- Ready to be deployed to any cloud service or hosted locally.

## Endpoints

### GET `/order`

Generates a random pizza order with the following details:

- Customer
- Pizza
- Topping
- Total Price
- Order Status (default: "ordered")
- Order Time (current system time)

### Example Response

```json
{
  "customer": {
    "name": "John Doe"
  },
  "pizza": {
    "name": "Pepperoni",
    "price": 9.99
  },
  "topping": {
    "name": "Mushrooms",
    "price": 1.5
  },
  "totalPrice": 11.49,
  "status": "ordered",
  "orderTime": "2024-10-01T12:34:56"
}
```

## How to Run Locally

1. Clone the repository:

   ```bash
   git clone https://github.com/your-repository/pizza-order-api.git
   cd pizza-order-api
   ```

2. Restore dependencies:

   ```bash
   dotnet restore
   ```

3. Build and run the project:

   ```bash
   dotnet run
   ```

4. Access the API at `http://localhost:5000/order`.

## How to Contribute

Feel free to fork the repository, make improvements, and submit pull requests!

## License

This project is licensed under the MIT License.
