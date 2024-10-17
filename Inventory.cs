public class Inventory
{
    private int _inventoryID;
    private Product _product;
    private int _quantityInStock;
    private DateTime _lastStockUpdate;

    public int InventoryID
    {
        get { return _inventoryID; }
        set
        {
            if (value > 0)
                _inventoryID = value;
            else
                throw new ArgumentException("InventoryID must be greater than 0.");
        }
    }

    public Product Product
    {
        get { return _product; }
        set { _product = value ?? throw new ArgumentNullException("Product cannot be null."); }
    }

    public int QuantityInStock
    {
        get { return _quantityInStock; }
        set
        {
            if (value >= 0)
                _quantityInStock = value;
            else
                throw new ArgumentException("QuantityInStock must be non-negative.");
        }
    }

    public DateTime LastStockUpdate
    {
        get { return _lastStockUpdate; }
        private set { _lastStockUpdate = value; } // Private setter, updated internally
    }

    // Constructor
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public Inventory(int inventoryId, Product product, int quantityInStock)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    {
        InventoryID = inventoryId;
        Product = product;
        QuantityInStock = quantityInStock;
        LastStockUpdate = DateTime.Now;
    }

    public void AddToInventory(int quantity)
    {
        QuantityInStock += quantity;
        LastStockUpdate = DateTime.Now;
        Console.WriteLine($"{quantity} units added to inventory.");
    }

    public void RemoveFromInventory(int quantity)
    {
        if (quantity <= QuantityInStock)
        {
            QuantityInStock -= quantity;
            LastStockUpdate = DateTime.Now;
            Console.WriteLine($"{quantity} units removed from inventory.");
        }
        else
        {
            throw new ArgumentException("Not enough stock to remove that quantity.");
        }
    }

    public bool IsProductAvailable(int quantityToCheck)
    {
        return QuantityInStock >= quantityToCheck;
    }

    public decimal GetInventoryValue()
    {
        return Product.Price * QuantityInStock;
    }

    public void ListLowStockProducts(int threshold)
    {
        if (QuantityInStock < threshold)
        {
            Console.WriteLine($"Low stock for product: {Product.ProductName}, Quantity: {QuantityInStock}");
        }
    }

    public void ListOutOfStockProducts()
    {
        if (QuantityInStock == 0)
        {
            Console.WriteLine($"Product {Product.ProductName} is out of stock.");
        }
    }

    public void ListAllProducts()
    {
        Console.WriteLine($"Product: {Product.ProductName}, Quantity in Stock: {QuantityInStock}");
    }

    internal void GetInventoryDetails()
    {
        throw new NotImplementedException();
    }
}
