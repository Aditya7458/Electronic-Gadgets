using System;

public class Payment
{
    public int PaymentID { get; set; }
    public decimal Amount { get; set; }
    public string Status { get; set; }

    public Payment(int paymentId, decimal amount, string status)
    {
        PaymentID = paymentId;
        Amount = amount;
        Status = status;
    }

    public void UpdatePaymentStatus(string newStatus)
    {
        Status = newStatus;
    }

    public void GetPaymentDetails()
    {
        Console.WriteLine($"Payment ID: {PaymentID}, Amount: {Amount:C}, Status: {Status}");
    }
}
