using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Welcome to the Hotel Booking System!");
            Console.Write("Enter the number of guests: ");
            int guestCount = int.Parse(Console.ReadLine());
            var guests = new List<Person>();

            for (int i = 1; i <= guestCount; i++)
            {
                Console.WriteLine($"\nEnter details for Guest {i}:");
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();

                guests.Add(new Person(firstName, lastName));
            }

            Console.WriteLine("\nEnter Suite details:");
            Console.Write("Suite Type: ");
            string suiteType = Console.ReadLine();

            Console.Write("Suite Capacity: ");
            int capacity = int.Parse(Console.ReadLine());

            Console.Write("Suite Daily Rate (in USD): ");
            decimal dailyRate = decimal.Parse(Console.ReadLine());

            var suite = new Suite(suiteType, capacity, dailyRate);

            Console.Write("\nEnter the number of days for reservation: ");
            int reservedDays = int.Parse(Console.ReadLine());

            var reservation = new Reservation(reservedDays);

            reservation.RegisterSuite(suite);
            reservation.RegisterGuests(guests);

            Console.WriteLine($"\nReservation Summary:");
            Console.WriteLine($"Number of guests: {reservation.GetGuestCount()}");
            Console.WriteLine($"Total daily rate: {reservation.CalculateDailyRate():C}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
