using System;

class Publisher
{
    public event EventHandler<CustomEventArgs> RaiseCustomEvent;
    public void RaiseEvent()
    {
        OnRaiseEvent(new CustomEventArgs(""));
    }
    protected virtual void OnRaiseEvent(CustomEventArgs e)
    {
        EventHandler<CustomEventArgs> handler = RaiseCustomEvent;
        if (handler != null)
        {
            e.Message += String.Format("{0:hh:mm:ss}", DateTime.Now);
            handler(this, e);
        }
        else
        {
            Console.WriteLine("There are no listeners.");
        }
    }
}
