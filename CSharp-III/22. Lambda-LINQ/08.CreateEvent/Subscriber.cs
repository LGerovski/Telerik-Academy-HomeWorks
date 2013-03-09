using System;

class Subscriber
{
    public Subscriber(Publisher myPublisher)
    {
        myPublisher.RaiseCustomEvent += HandleEvent;
    }
    void HandleEvent(object sender, CustomEventArgs e)
    {
        Console.WriteLine("The time now is: {0}", e.Message);
    }
}