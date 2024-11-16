namespace SmartphoneApp.Models
{
    public class Iphone : Smartphone
    {
        public string iOSVersion { get; set; }

        public Iphone(string number, string model, string imei, int memory, string iOSVersion)
            : base(number, model, imei, memory)
        {
            this.iOSVersion = iOSVersion;
        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Installing {appName} from the App Store on iPhone. iOS: {iOSVersion}");
        }

        public void UpdateiOS(string newVersion)
        {
            iOSVersion = newVersion;
            Console.WriteLine($"iOS updated to version {iOSVersion}.");
        }

        public void SendiMessage(string targetNumber, string message)
        {
            Console.WriteLine($"iMessage to {targetNumber}: {message}");
        }
    }
}
