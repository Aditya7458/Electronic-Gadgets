public class Product
{
    private int _productID;
    private string _productName;
    private string _description;
    private decimal _price;
    private bool _inStock;
    private string v1;
    private int v2;

    public int ProductID
    {
        get { return _productID; }
        set
        {
            if (value > 0)
                _productID = value;
            else
                throw new ArgumentException("ProductID must be greater than 0.");
        }
    }

    public string ProductName
    {
        get { return _productName; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _productName = value;
            else
                throw new ArgumentException("ProductName cannot be empty.");
        }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public decimal Price
    {
        get { return _price; }
        set
        {
            if (value >= 0)
                _price = value;
            else
                throw new ArgumentException("Price must be non-negative.");
        }
    }

    public bool InStock
    {
        get { return _inStock; }
        set { _inStock = value; }
    }

    // Constructor
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public Product(int productId, string productName, string description, decimal price, bool inStock)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    {
        ProductID = productId;
        ProductName = productName;
        Description = description;
        Price = price;
        InStock = inStock;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public Product(int productId, string v1, int v2)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    {
        ProductID = productId;
        this.v1 = v1;
        this.v2 = v2;
    }

    public void GetProductDetails()
    {
        Console.WriteLine($"Product ID: {ProductID}, Name: {ProductName}, Description: {Description}, Price: {Price:C}, In Stock: {InStock}");
    }

    public void UpdateProductInfo(decimal price, string description)
    {
        Price = price;
        Description = description;
        Console.WriteLine("Product information updated.");
    }

    public bool IsProductInStock()
    {
        return InStock;
    }

    internal void UpdateProductInfo(string name, decimal price)
    {
        throw new NotImplementedException();
    }
}
