using System;
using System.Collections.Generic;

public class Parking
{
    private List<string> vehicles = new List<string>();
    private decimal initialFee;
    private decimal hourlyFee;
    public Parking(decimal initialFee, decimal hourlyFee)
    {
        this.initialFee = initialFee;
        this.hourlyFee = hourlyFee;
    }
    public void AddVehicle(string licensePlate)
    {
        bool verification = false;
        foreach (string vehicle in vehicles){
            if(vehicle==licensePlate){
                verification = true;
            }
        }
        if(!verification){
            vehicles.Add(licensePlate);
            Console.WriteLine($"Vehicle with license plate {licensePlate} added.");
        }
        else{
            Console.WriteLine($"Vehicle already added.");
        }
    }
    public void RemoveVehicle(string licensePlate, int hoursParked)
    {
        if (vehicles.Contains(licensePlate))
        {
            decimal totalFee = initialFee + hourlyFee * hoursParked;
            vehicles.Remove(licensePlate);
            Console.WriteLine($"Vehicle {licensePlate} removed. Total fee: {totalFee:C2}");
        }
        else
        {
            Console.WriteLine("Sorry, this vehicle is not parked here.");
        }
    }
    public void ListVehicles()
    {
        if (vehicles.Count > 0)
        {
            Console.WriteLine("Parked vehicles:");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
        else
        {
            Console.WriteLine("No vehicles are currently parked.");
        }
    }
}
