using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket
{
    class Screen
    {
        //Menu
        public static void DisplayMenuOption()
        {
            Console.Clear();
            Console.WriteLine("==============Ticket==================");
            Console.WriteLine("1: VIP Ticket");
            Console.WriteLine("2: Normal Ticket");
            Console.WriteLine("3: Exit");

        }
        
        public static string EnterPassengerName()
        {
            Console.Write("Enter Passenger's Full Name: ");
            return Console.ReadLine();
        }
        public static string EnterPassengerGender()
        {
            Console.Write("Enter Passenger's Gender: ");
            return Console.ReadLine();
        }
        public static byte EnterPassengerAge()
        {
            Console.Write("Enter Passenger's Age: ");
            return byte.Parse(Console.ReadLine());
        }
        public static string EnterFlightDate()
        {
            Console.Write("Enter Flight Date: ");
            string input = Console.ReadLine();
            DateTime date;
            if (DateTime.TryParse(input, out date))
            {
                return String.Format("{0:d/MM/yyyy}", date);
            }
            else
            {
                return "INVALID";
            }
        }
        public static void FindFailed()
        {
            Console.WriteLine("COULDN'T FIND ANYONE ");
        }
        public static string EnterDestination()
        {
            Console.Write("Enter Destination: ");
            return Console.ReadLine();
        }
        public static void DisplayInvalidOption()
        {
            Console.WriteLine("INVALID OPTION! PLEASE TRY AGAIN!");
        }
    }
}
