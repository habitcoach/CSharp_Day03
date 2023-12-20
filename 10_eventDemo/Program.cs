using System;

// Step 1: Define a delegate for the event
public delegate void SignalEventHandler(EventArgs e);

//Delegate define the method handler signature that can subscribe to the event
public class SignalSystem
{
    // Step 2: Define the event based on the delegate.  IT specifies the type of handler that can be invoked
    public event SignalEventHandler SignalEvent;

    // Step 3: Method to raise the event
    public void SendSignal()
    {
        Console.WriteLine("Sending Signal...");
        OnSignalEvent(EventArgs.Empty); // Raise the event
    }

    // Step 4: Method to invoke the event
    public virtual void OnSignalEvent(EventArgs e)
    {
        SignalEventHandler handler = SignalEvent;

        #region notes
        //This line makes a copy of the event delegate (SignalEvent) and stores it in a local variable handler.
        //This is done to avoid issues related to the event being modified by other threads while the event is being invoked.
        #endregion

        if (handler != null)
        {
            handler(e); // Trigger the event
        }
    }
}

public class Receiver //event handler
{
   
    
    // Step 6: Event handler method
    public void OnSignalReceived( EventArgs e)
    {
        Console.WriteLine("Signal Received! by receiver 01");
        Thread.Sleep(1000);
    }
}

public class Receiver02
{
   

    // Step 6: Event handler method
    public void OnSignalReceived(EventArgs e)
    {
        Console.WriteLine("Signal Received! by receiver 02");
        Thread.Sleep(1000);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create the signal system and receiver
        SignalSystem signalSystem = new SignalSystem();

          Receiver receiver = new Receiver();

        signalSystem.SignalEvent += receiver.OnSignalReceived;

        Receiver02 receiver02 = new Receiver02();

        signalSystem.SignalEvent += receiver02.OnSignalReceived;


        // Send signal and observe the output
        signalSystem.SendSignal();

        //Unsubscribe the event
        signalSystem.SignalEvent -= receiver.OnSignalReceived;

        // Sending signal again, but receiver won't handle it
        signalSystem.SendSignal();
    }
}
