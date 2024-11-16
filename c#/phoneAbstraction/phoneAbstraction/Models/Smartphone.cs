namespace SmartphoneApp.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        public string Model { get; set; }
        public string IMEI { get; set; }
        public int Memory { get; set; }

        public Smartphone(string number, string model, string imei, int memory)
        {
            Number = number;
            Model = model;
            IMEI = imei;
            Memory = memory;
        }

        public void Call(string targetNumber)
        {
            Console.WriteLine($"Calling {targetNumber} from {Number}...");
        }

        public void ReceiveCall(string callerNumber)
        {
            Console.WriteLine($"Receiving a call from {callerNumber} on {Number}...");
        }

        public virtual void SendMessage(string targetNumber, string message)
        {
            Console.WriteLine($"Sending message to {targetNumber}: {message}");
        }

        public abstract void InstallApp(string appName);
    }
}
