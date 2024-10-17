public class Customer
{
    private int _customerID;
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _phone;
    private string _address;
    private int _totalOrders;

    // Public properties with validation
    public int CustomerID
    {
        get { return _customerID; }
        set
        {
            if (value > 0)
                _customerID = value;
            else
                throw new ArgumentException("CustomerID must be greater than 0.");
        }
    }

    public string FirstName
    {
        get { return _firstName; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _firstName = value;
            else
                throw new ArgumentException("FirstName cannot be empty.");
        }
    }

    public string LastName
    {
        get { return _lastName; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _lastName = value;
            else
                throw new ArgumentException("LastName cannot be empty.");
        }
    }

    public string Email
    {
        get { return _email; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Contains("@"))
                _email = value;
            else
                throw new ArgumentException("Invalid email address.");
        }
    }

    public string Phone
    {
        get { return _phone; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _phone = value;
            else
                throw new ArgumentException("Phone cannot be empty.");
        }
    }

    public string Address
    {
        get { return _address; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _address = value;
            else
                throw new ArgumentException("Address cannot be empty.");
        }
    }

    public int TotalOrders
    {
        get { return _totalOrders; }
        private set { _totalOrders = value; } // Private setter, can only be updated internally
    }

    // Constructor
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public Customer(int customerId, string firstName, string lastName, string email, string phone, string address)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    {
        CustomerID = customerId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Address = address;
        TotalOrders = 0;
    }

    public int CalculateTotalOrders()
    {
        return TotalOrders;
    }

    public void GetCustomerDetails()
    {
        Console.WriteLine($"Customer ID: {CustomerID}, Name: {FirstName} {LastName}, Email: {Email}, Phone: {Phone}, Address: {Address}, Total Orders: {TotalOrders}");
    }

    public void UpdateCustomerInfo(string email, string phone, string address)
    {
        Email = email;
        Phone = phone;
        Address = address;
        Console.WriteLine("Customer information updated.");
    }

    public void PlaceOrder()
    {
        TotalOrders++;
    }
}
