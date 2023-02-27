namespace Events;


public delegate void MyEventHandler(object sender, MyEventArgs e);

public class EventProducer
{
    // Event deklarieren
    public event MyEventHandler MyEvent;
    // Event "feuern"
    public void OnMyEvent(string data)
    {
        if (MyEvent != null)
            MyEvent(this, new MyEventArgs(data));
    }
}