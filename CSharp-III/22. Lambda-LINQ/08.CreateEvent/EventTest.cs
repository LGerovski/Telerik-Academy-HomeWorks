using System.Threading;

class EventTest
{
    static void Main()
    {
        Publisher myPublisher = new Publisher();
        Subscriber mySubscriber = new Subscriber(myPublisher);
        for (int i = 0; i < 10; i++)
        {
            myPublisher.RaiseEvent();
            Thread.Sleep(1500);
        }
    }
}