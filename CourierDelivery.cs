using System;

public class CourierDelivery : IDelivery
{
    public void DeliverOrder(Order order)
    {
        Console.WriteLine("Доставка курьером выполнена");
    }
}
