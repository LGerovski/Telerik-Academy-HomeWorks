using System;

public class CustomEventArgs : EventArgs
{
    public string Message { get; set; }
    public CustomEventArgs(string message)
    {
        this.Message = message;
    }
}