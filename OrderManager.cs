using System;
using System.Collections.Generic;
using System.Linq;

public class OrderManager
{
    private List<Order> orders;

    public OrderManager()
    {
        orders = new List<Order>();
    }

    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    public void UpdateOrderStatus(int orderId, string newStatus)
    {
        var order = orders.FirstOrDefault(o => o.OrderID == orderId);
        if (order == null)
        {
            throw new Exception("Order not found.");
        }
        order.UpdateOrderStatus(newStatus);
    }

    public void RemoveOrder(int orderId)
    {
        var order = orders.FirstOrDefault(o => o.OrderID == orderId);
        if (order == null)
        {
            throw new Exception("Order not found.");
        }
        orders.Remove(order);
    }

    public void ListOrders()
    {
        foreach (var order in orders)
        {
            order.GetOrderDetails();
        }
    }

    public void SortOrdersByDate(bool ascending = true)
    {
        if (ascending)
        {
            orders = orders.OrderBy(o => o.OrderDate).ToList();
        }
        else
        {
            orders = orders.OrderByDescending(o => o.OrderDate).ToList();
        }
    }
}
