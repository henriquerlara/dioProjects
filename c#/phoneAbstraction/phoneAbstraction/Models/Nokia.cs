namespace SmartphoneApp.Models
{
    public class Nokia : Smartphone
    {
        public string FirmwareVersion { get; set; }

        public Nokia(string number, string model, string imei, int memory, string firmwareVersion)
            : base(number, model, imei, memory)
        {
            FirmwareVersion = firmwareVersion;
        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Installing {appName} on Nokia. Firmware: {FirmwareVersion}");
        }

        public void UpdateFirmware(string newVersion)
        {
            FirmwareVersion = newVersion;
            Console.WriteLine($"Firmware updated to version {FirmwareVersion}.");
        }

        public override void SendMessage(string targetNumber, string message)
        {
            Console.WriteLine($"Nokia SMS to {targetNumber}: {message} (sent using Nokia's special messaging system)");
        }
    }
}
