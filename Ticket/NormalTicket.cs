using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket
{
    class NormalTicket:FlightTicket
    {
        public double price = 50.5;
        public NormalTicket(string fullName, string gender, int age, string flightDate, string destination) : base(fullName, gender, age, flightDate, destination)
        {
        }
        public double Price()
        {
            return this.price;
        }
    }
}
