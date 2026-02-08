using System;

class Program
{
    static void Main()
    {
        Order order = new Order();

        order.AddItem(new Product("Ноутбук", 500000), 1);

        order.Payment = new CreditCardPayment();
        order.Delivery = new CourierDelivery();

        order.Checkout();

        INotification notification = new EmailNotification();
        notification.SendNotification("Ваш заказ оформлен");
    }
}
