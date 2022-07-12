using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket
{
    public abstract class FlightTicket
    {
        public string FullName;
        public string Gender;
        public int Age;
        public string FlightDate;
        public string Destination;
        public FlightTicket(string fullName, string gender, int age, string flightDate, string destination)
        {
            FullName = fullName;
            Gender = gender;
            Age = age;
            FlightDate = flightDate;
            Destination = destination;
        }
        public string DisplayTicket()
        {
            string result = "==================================\n" +
            $"FULL NAME: {FullName} \n" +
            $"GENDER: {Gender} \n" +
            $"AGE: {Age} \n" +
            $"FLIGHT DATE: {FlightDate} \n" +
            $"DESTINATION: {Destination}\n" +
            "==================================\n";
            return result;

        }
    }
}

