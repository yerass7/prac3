using System.Collections.Generic;
using System.Linq;

public class Order
{
    public List<OrderItem> Items = new();
    public IPayment Payment;
    public IDelivery Delivery;

    public void AddItem(Product product, int quantity)
    {
        Items.Add(new OrderItem(product, quantity));
    }

    public double CalculateTotal()
    {
        return Items.Sum(i => i.GetTotal());
    }

    public void Checkout()
    {
        double total = CalculateTotal();
        Payment.ProcessPayment(total);
        Delivery.DeliverOrder(this);
    }
}
