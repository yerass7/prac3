using System;

public class EmailNotification : INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Email отправлен: {message}");
    }
}
