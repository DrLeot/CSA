namespace Events;

public class MyEventArgs : EventArgs
{

    public string EventData;
    
    public MyEventArgs(string data)
    {
        EventData = data;   
    }
}