using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket
{
    public class VIPTicket : FlightTicket
    {
        public double price = 100.5;
        public VIPTicket(string fullName, string gender, int age, string flightDate, string destination) : base(fullName, gender, age, flightDate, destination)
        {
        }
        public double Price()
        {
            return this.price;
        }
    }
}
