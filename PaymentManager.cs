using System;
using System.Collections.Generic;

public class PaymentManager
{
    private List<Payment> paymentRecords;

    public PaymentManager()
    {
        paymentRecords = new List<Payment>();
    }

    public void RecordPayment(Payment payment)
    {
        paymentRecords.Add(payment);
    }

    public void UpdatePaymentStatus(int paymentId, string status)
    {
        var payment = paymentRecords.Find(p => p.PaymentID == paymentId);
        if (payment == null)
        {
            throw new InvalidDataException("Payment not found.");
        }
        payment.UpdatePaymentStatus(status);
    }

    public void ListPayments()
    {
        foreach (var payment in paymentRecords)
        {
            payment.GetPaymentDetails();
        }
    }
}
