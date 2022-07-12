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
                Console.Write("Enter number of features: ");
                order = Byte.Parse(Console.ReadLine());
                switch (order)
                {
                    case Request.AddTicket:
                        plane.AddTicket(new FlightTicket
                        (Screen.EnterPassengerName(),
                       Screen.EnterPassengerGender(),
                       Screen.EnterPassengerAge(),
                       Screen.EnterFlightDate(),
                       Screen.EnterDestination()));
                        Console.ReadLine();
                        break;
                    case Request.UpdateTicket:
                        var ticketToUpdate = Screen.EnterPassengerName();
                        if (plane.UpdateStatus(ticketToUpdate))
                        {
                            var newGender = Screen.EnterPassengerGender();
                            var newAge = Screen.EnterPassengerAge();
                            var newDate = Screen.EnterFlightDate();
                            var newDestination = Screen.EnterDestination();
                            plane.UpdateTicket(ticketToUpdate, newGender,
                           newAge, newDate, newDestination);
                        }
                        else
                        {
                            Screen.FindFailed();
                        }
                        Console.ReadLine();
                        break;
                    case Request.RemoveTicket:
                        var ticketToRemove = Screen.EnterPassengerName();
                        plane.RemoveTicket(ticketToRemove);
                        Console.ReadLine();
                        break;
                    case Request.SearchTicket:
                        Screen.DisplaySearchMenu();
                        byte searchRequest = Byte.Parse(Console.ReadLine());
                        switch (searchRequest)
                        {
                            case Request.SearchName:
                                var searchName = Screen.EnterPassengerName();
                                plane.SearchTicket(searchName);
                                Console.ReadLine();
                                break;
                            case Request.SearchDate:
                                var searchDate = Screen.EnterFlightDate();
                                plane.SearchFlightDate(searchDate);
                                Console.ReadLine();
                                break;
                            case Request.SearchDestination:
                                var searchDestination =
                               Screen.EnterDestination();

                                plane.SearchFlightDestination(searchDestination);
                                Console.ReadLine();
                                break;
                            default:
                                Screen.DisplayInvalidOption();
                                break;
                        }
                        break;
                    case Request.PrintTickets:
                        plane.PrintListOfTicket();
                        Console.ReadLine();
                        break;
                    case Request.Exit:
                        return;

                    default:
                        Screen.DisplayInvalidOption();
                        break;
                }
            } while (order != 6);
        }
    }
}
