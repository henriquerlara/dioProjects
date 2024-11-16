namespace SmartphoneApp.Models
{
    public sealed class Charger
    {
        public string Brand { get; set; }
        public int PowerOutput { get; set; } // this property is measured in watts

        public Charger(string brand, int powerOutput)
        {
            Brand = brand;
            PowerOutput = powerOutput;
        }

        public void ChargeDevice(Smartphone smartphone)
        {
            Console.WriteLine($"Charging {smartphone.Model} with {Brand} charger ({PowerOutput}W).");
        }
    }
}
