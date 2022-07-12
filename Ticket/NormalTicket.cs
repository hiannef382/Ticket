using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket
{
    class NormalTicket:FlightTicket, ITicket
    {
        protected double price = 50.5;
        public NormalTicket(string fullName, string gender, int age, string flightDate, string destination) : base(fullName, gender, age, flightDate, destination)
        {
        }
        public double Price()
        {
            return this.price;
        }
        public override string ToString()
        {
            return "\n================================== \n" +
            "TYPE TICKET: NOMAL \n" +
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
