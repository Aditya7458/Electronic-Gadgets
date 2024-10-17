public class Order
{
    private int _orderID;
    private Customer _customer;
    private DateTime _orderDate;
    private decimal _totalAmount;
    private string _orderStatus;

    public int OrderID
    {
        get { return _orderID; }
        set
        {
            if (value > 0)
                _orderID = value;
            else
                throw new ArgumentException("OrderID must be greater than 0.");
        }
    }

    public Customer Customer
    {
        get { return _customer; }
        set { _customer = value ?? throw new ArgumentNullException("Customer cannot be null."); }
    }

    public DateTime OrderDate
    {
        get { return _orderDate; }
        set { _orderDate = value; }
    }

    public decimal TotalAmount
    {
        get { return _totalAmount; }
        set
        {
            if (value >= 0)
                _totalAmount = value;
            else
                throw new ArgumentException("TotalAmount must be non-negative.");
        }
    }

    public string OrderStatus
    {
        get { return _orderStatus; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _orderStatus = value;
            else
                throw new ArgumentException("OrderStatus cannot be empty.");
        }
    }

    // Constructor
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public Order(int orderId, Customer customer, DateTime orderDate, decimal totalAmount)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    {
        OrderID = orderId;
        Customer = customer;
        OrderDate = orderDate;
        TotalAmount = totalAmount;
        OrderStatus = "Processing"; // Default status
    }

    public decimal CalculateTotalAmount()
    {
        return TotalAmount;
    }

    public void GetOrderDetails()
    {
        Console.WriteLine($"Order ID: {OrderID}, Customer: {Customer.FirstName} {Customer.LastName}, Order Date: {OrderDate}, Total Amount: {TotalAmount:C}, Status: {OrderStatus}");
    }

    public void UpdateOrderStatus(string status)
    {
        OrderStatus = status;
        Console.WriteLine($"Order status updated to: {status}");
    }

    public void CancelOrder()
    {
        OrderStatus = "Cancelled";
        Console.WriteLine("Order has been canceled.");
    }
}
