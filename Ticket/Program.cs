using System;

namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            byte order;
            var plane = new Plane("VietJet");
            do
            {
                Screen.DisplayMenuOption();
                Console.Write("Enter number of choice: ");
                order = Byte.Parse(Console.ReadLine());
                switch (order)
                {
                    case Request.VIPTicket:
                        VIPTicket vip = new VIPTicket(Screen.EnterPassengerName(),
                        Screen.EnterPassengerGender(),
                        Screen.EnterPassengerAge(),
                        Screen.EnterFlightDate(),
                        Screen.EnterDestination());
                        Console.WriteLine($"Price of Ticket is {vip.Price()}");
                        Console.ReadLine();

                        break;
                    case Request.NormalTicket:
                        NormalTicket normal = new NormalTicket(Screen.EnterPassengerName(),
                        Screen.EnterPassengerGender(),
                        Screen.EnterPassengerAge(),
                        Screen.EnterFlightDate(),
                        Screen.EnterDestination());
                        Console.WriteLine($"Price of Ticket is {normal.Price()}");
                        Console.ReadLine();

                        break;

                    case Request.Exit:
                        break;
                    default:
                        Screen.DisplayInvalidOption();
                        break;
                }
            } while (order != 3);
        }
    }
}
