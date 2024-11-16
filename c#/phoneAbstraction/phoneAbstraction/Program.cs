using SmartphoneApp.Models;

class Program
{
    static void Main(string[] args)
    {
        Nokia nokia = new Nokia("123456789", "Nokia 3310", "000111222333", 64, "1.0.0");
        Console.WriteLine("Testing Nokia:");
        nokia.Call("987654321");
        nokia.ReceiveCall("555666777");
        nokia.InstallApp("Snake Game");
        nokia.UpdateFirmware("1.1.0");
        nokia.SendMessage("987654321", "Hello from Nokia!");

        Iphone iphone = new Iphone("987654321", "iPhone 12", "333444555666", 128, "16.0");
        Console.WriteLine("\nTesting iPhone:");
        iphone.Call("123456789");
        iphone.ReceiveCall("444555666");
        iphone.InstallApp("Instagram");
        iphone.UpdateiOS("17.0");
        iphone.SendiMessage("123456789", "Hello from iPhone!");

        Charger charger = new Charger("Anker", 20);
        Console.WriteLine("\nTesting Charger:");
        charger.ChargeDevice(nokia);
        charger.ChargeDevice(iphone);
    }
}
