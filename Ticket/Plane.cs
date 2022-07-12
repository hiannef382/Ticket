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
        public void SearchTicket(string fullName)
        {
            int search = Tickets.Count(a => a.FullName == fullName);
            Console.WriteLine($"FOUND {search} RESULT(S)");
            if (search != 0)
            {
                foreach (var item in Tickets)
                {
                    var searchName = Tickets.FirstOrDefault(a => a.FullName ==
                   fullName);
                    if (item.FullName == searchName.FullName)
                    {
                        Console.WriteLine(item.DisplayTicket());
                    }
                }
            }
        }
        public void SearchFlightDate(string date)
        {
            int search = Tickets.Count(a => a.FlightDate.Equals(date));
            Console.WriteLine($"FOUND {search} RESULT(S)");
            if (search != 0)
            {
                foreach (var item in Tickets)
                {
                    var searchDate = Tickets.FirstOrDefault(a => a.FlightDate.Equals(date));
                    if (item.FlightDate == searchDate.FlightDate)

                    {
                        Console.WriteLine(item.DisplayTicket());
                    }
                }
            }
        }

            public void SearchFlightDestination(string destination)
            {
            int search = Tickets.Count(a => a.Destination == destination);
            Console.WriteLine($"FOUND {search} RESULT(S)");
            if (search != 0)
            {
                foreach (var item in Tickets)
                {
                    var searchDestination = Tickets.FirstOrDefault(a =>
                   a.Destination == destination);
                    if (item.Destination == searchDestination.Destination)
                    {
                        Console.WriteLine(item.DisplayTicket());
                    }
                }
            }
        }
        public void RemoveTicket(string ticketToDelete)
        {
            var passengerInPlane = Tickets.FirstOrDefault(a =>
           a.FullName.Equals(ticketToDelete));
            if (passengerInPlane != null)
            {
                Tickets.Remove(passengerInPlane);
                Console.WriteLine("REMOVE SUCCEED!");
            }
            else
            {
                Console.WriteLine("REMOVE FAILED!");
            }
        }
        public bool UpdateStatus(string updateName)
        {
            var passengerInPlane = Tickets.FirstOrDefault(a =>
           a.FullName.Equals(updateName));
            if (passengerInPlane != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UpdateTicket(string updateName, string newGender, byte
        newAge,
         string newDate, string newDestination)
        {
            var passengerInPlane = Tickets.FirstOrDefault(a =>
           a.FullName.Equals(updateName));
            if (passengerInPlane != null)
            {
                passengerInPlane.Gender = newGender;
                passengerInPlane.Age = newAge;
                passengerInPlane.FlightDate = newDate;
                passengerInPlane.Destination = newDestination;
                Console.WriteLine("UPDATE SUCCEED!");
                Console.WriteLine(passengerInPlane.DisplayTicket());
            }
            else
            {
                Console.WriteLine("UPDATE FAILED!");
            }
        }
        public void PrintListOfTicket()
        {
            if (Tickets.Any())
            {
                foreach (var ticket in Tickets)
                {
                    Console.WriteLine(ticket.DisplayTicket());
                }
            }
            else
            {
                Console.WriteLine("THERE IS NO TICKET AVAILABLE");
            }
        }
    }
}

