using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a customer
        Customer customer = new Customer(1, "Aditya", "Rajput", "aditya@example.com", "1234567890", "Bhopal, India");
        customer.GetCustomerDetails();

        // Create products
        Product product1 = new Product(101, "Laptop", "High-performance laptop", 1500.00m, true);
        Product product2 = new Product(102, "Smartphone", "Latest model smartphone", 800.00m, true);
        Product product3 = new Product(103, "Headphones", "Noise-cancelling headphones", 200.00m, false); // Out of stock

        product1.GetProductDetails();
        product2.GetProductDetails();
        product3.GetProductDetails();

        // Add products to inventory
        Inventory inventory1 = new Inventory(1, product1, 10);
        Inventory inventory2 = new Inventory(2, product2, 5);
        Inventory inventory3 = new Inventory(3, product3, 0); // Out of stock

        // List all products in inventory
        Console.WriteLine("\n--- Inventory List ---");
        inventory1.ListAllProducts();
        inventory2.ListAllProducts();
        inventory3.ListAllProducts();

        // Create an order for the customer
        Order order = new Order(1001, customer, DateTime.Now, 0);
        OrderDetail orderDetail1 = new OrderDetail(1, order, product1, 2, 0); // 2 Laptops
        OrderDetail orderDetail2 = new OrderDetail(2, order, product2, 1, 50); // 1 Smartphone with $50 discount

        // Display order details
        Console.WriteLine("\n--- Order Details ---");
        orderDetail1.GetOrderDetailInfo();
        orderDetail2.GetOrderDetailInfo();

        // Calculate total amount for the order
        order.TotalAmount = orderDetail1.CalculateSubtotal() + orderDetail2.CalculateSubtotal();
        order.GetOrderDetails();

        // Update order status
        order.UpdateOrderStatus("Shipped");

        // Inventory adjustments after placing the order
        inventory1.RemoveFromInventory(orderDetail1.Quantity); // Reduce stock for product1 (Laptop)
        inventory2.RemoveFromInventory(orderDetail2.Quantity); // Reduce stock for product2 (Smartphone)

        // Check inventory after order placement
        Console.WriteLine("\n--- Inventory After Order ---");
        inventory1.ListAllProducts();
        inventory2.ListAllProducts();

        // List low stock products (Threshold: 3 units)
        Console.WriteLine("\n--- Low Stock Products ---");
        inventory1.ListLowStockProducts(3);
        inventory2.ListLowStockProducts(3);
        inventory3.ListOutOfStockProducts(); // Out-of-stock check for headphones
    }
}
