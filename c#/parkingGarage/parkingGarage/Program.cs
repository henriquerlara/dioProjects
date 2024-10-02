using System;

class Program
{
    static void Main(string[] args)
    {
        Parking parking = new Parking(initialFee: 5.00m, hourlyFee: 2.00m);

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1 - Add vehicle");
            Console.WriteLine("2 - Remove vehicle");
            Console.WriteLine("3 - List vehicles");
            Console.WriteLine("4 - Exit");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Enter the vehicle's license plate:");
                    string licensePlate = Console.ReadLine();
                    parking.AddVehicle(licensePlate);
                    break;

                case "2":
                    Console.WriteLine("Enter the vehicle's license plate:");
                    licensePlate = Console.ReadLine();
                    Console.WriteLine("Enter the number of hours parked:");
                    int hours = int.Parse(Console.ReadLine());
                    parking.RemoveVehicle(licensePlate, hours);
                    break;

                case "3":
                    parking.ListVehicles();
                    break;

                case "4":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
