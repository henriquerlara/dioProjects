using System;
using System.Collections.Generic;

public class Reservation
{
    public List<Person> Guests { get; set; }
    public Suite Suite { get; set; }
    public int ReservedDays { get; set; }

    public Reservation() 
    {
        Guests =new List<Person>();
    }

    public Reservation(int reservedDays) : this()
    {
        ReservedDays = reservedDays;
    }

    public void RegisterGuests(List<Person> guests)
    {
        if (Suite== null)
        {
            throw new Exception("Suite must be registered before adding guests.");
        }

        if (guests.Count <= Suite.Capacity)
        {
            Guests =guests;
        }
        else
        {
            throw new Exception("The number of guests exceeds the suite's capacity.");
        }
    }

    public void RegisterSuite(Suite suite)
    {
        Suite = suite;
    }

    public int GetGuestCount()
    {
        return Guests.Count;
    }

    public decimal CalculateDailyRate()
    {
        if (Suite == null)
        {
            throw new Exception("Suite must be registered to calculate the daily rate.");
        }

        decimal totalRate = ReservedDays * Suite.DailyRate;
        if (ReservedDays > 10)
        {
            totalRate *= 0.9M;
        }
        return totalRate;
    }
}
