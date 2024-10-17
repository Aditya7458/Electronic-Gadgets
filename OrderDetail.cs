public class OrderDetail
{
    private int _orderDetailID;
    private Order _order;
    private Product _product;
    private int _quantity;
    private decimal _discount;

    public int OrderDetailID
    {
        get { return _orderDetailID; }
        set
        {
            if (value > 0)
                _orderDetailID = value;
            else
                throw new ArgumentException("OrderDetailID must be greater than 0.");
        }
    }

    public Order Order
    {
        get { return _order; }
        set { _order = value ?? throw new ArgumentNullException("Order cannot be null."); }
    }

    public Product Product
    {
        get { return _product; }
        set { _product = value ?? throw new ArgumentNullException("Product cannot be null."); }
    }

    public int Quantity
    {
        get { return _quantity; }
        set
        {
            if (value > 0)
                _quantity = value;
            else
                throw new ArgumentException("Quantity must be greater than 0.");
        }
    }

    public decimal Discount
    {
        get { return _discount; }
        set
        {
            if (value >= 0)
                _discount = value;
            else
                throw new ArgumentException("Discount must be non-negative.");
        }
    }

    // Constructor
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public OrderDetail(int orderDetailId, Order order, Product product, int quantity, decimal discount)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    {
        OrderDetailID = orderDetailId;
        Order = order;
        Product = product;
        Quantity = quantity;
        Discount = discount;
    }

    public decimal CalculateSubtotal()
    {
        return (Product.Price * Quantity) - Discount;
    }

    public void GetOrderDetailInfo()
    {
        Console.WriteLine($"OrderDetail ID: {OrderDetailID}, Product: {Product.ProductName}, Quantity: {Quantity}, Subtotal: {CalculateSubtotal():C}");
    }

    public void UpdateQuantity(int quantity)
    {
        Quantity = quantity;
        Console.WriteLine("Quantity updated.");
    }

    public void AddDiscount(decimal discount)
    {
        Discount = discount;
        Console.WriteLine("Discount applied.");
    }
}
