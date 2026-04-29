// Program to demonstrate events 
using System;
// Define a delegate for the event
delegate void ThresholdReachedEventHandler(object sender, EventArgs e);
// Define a class that raises an event when a threshold is reached
class Counter
{
    public event ThresholdReachedEventHandler ThresholdReached;
    private int threshold;
    private int total;

    public Counter(int threshold)
    {
        this.threshold = threshold;
    }

    public void Add(int value)
    {
        total += value;
        if (total >= threshold)
        {
            OnThresholdReached(EventArgs.Empty);
        }
    }

    protected virtual void OnThresholdReached(EventArgs e)
    {
        ThresholdReached?.Invoke(this, e);
    }
}
class Program
{
    static void Main()
    {
        Counter counter = new Counter(10);
        counter.ThresholdReached += Counter_ThresholdReached;

        counter.Add(3);
        counter.Add(4);
        counter.Add(5); // This will trigger the event
    }

    private static void Counter_ThresholdReached(object sender, EventArgs e)
    {
        Console.WriteLine("Threshold reached!");
    }
}
