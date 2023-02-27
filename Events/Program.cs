namespace Events;

public class Program
{
    /// <summary>
    /// Hauptprogramm: Erzeugt einen Event-Producer sowie zwei
    /// Consumer die sich beim Event des Producers registrieren.
    /// </summary>
    public Program()
    {
        EventProducer producer = new EventProducer();
        EventConsumer consumer1 = new EventConsumer(producer);
        EventConsumer consumer2 = new EventConsumer(producer);
        producer.OnMyEvent("Event fired...");
        Console.ReadLine();
    }
    static void Main(string[] args)
    {
        Program prog = new Program();
        Console.Read();
    }
}
