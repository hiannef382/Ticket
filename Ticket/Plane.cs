using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticket
{
    public class Plane
    {
        public string PlaneCode;
        public List<FlightTicket> Tickets;
        public Plane(string name)
        {
            PlaneCode = name;
            Tickets = new List<FlightTicket>();
        }
        public void AddTicket(FlightTicket passenger)
        {
            Tickets.Add(passenger);
            Console.WriteLine();
            Console.WriteLine("CREATED SUCCEED!");
            Console.WriteLine("Passenger's ticket:");
            Console.Write($"\n Full name: {passenger.FullName}" +
            $"\n Gender: {passenger.Gender}" +
            $"\n Age: {passenger.Age}" +
            $"\n Flight Date: {passenger.FlightDate}" +
            $"\n Destination: {passenger.Destination}");
        }
  
    }
}

