using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket
{
    public class VIPTicket : FlightTicket, ITicket
    {
        protected double price = 100.5;
        public VIPTicket(string fullName, string gender, int age, string flightDate, string destination) : base(fullName, gender, age, flightDate, destination)
        {
        }
        public double Price()
        {
            return this.price;
        }

        public override string ToString()
        {
            return "\n================================== \n" +
            "TYPE TICKET: VIP \n" +
            $"FULL NAME: {FullName} \n" +
            $"GENDER: {Gender} \n" +
            $"AGE: {Age} \n" +
            $"FLIGHT DATE: {FlightDate} \n" +
            $"DESTINATION: {Destination}\n" +
            $"PRICE: {this.price}\n" +
            "==================================\n";
        }
    }
}
