using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket
{
    class Request
    {
        public const byte AddTicket = 1;
        public const byte UpdateTicket = 2;
        public const byte RemoveTicket = 3;
        public const byte SearchTicket = 4;
        public const byte PrintTickets = 5;
        public const byte Exit = 6;
        public const byte SearchName = 1;
        public const byte SearchDate = 2;
        public const byte SearchDestination = 3;
    }
}
