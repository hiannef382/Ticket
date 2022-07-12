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
            Console.WriteLine("===================================");
            Console.WriteLine("1: Add New Ticket");
            Console.WriteLine("2: Update Ticket's Information");
            Console.WriteLine("3: Remove A Ticket By Name");
            Console.WriteLine("4: Search Ticket");
            Console.WriteLine("5: Print All Ticket");
            Console.WriteLine("6: Exit Application");
            Console.WriteLine("===================================");
        }
        //Menu of search
        public static void DisplaySearchMenu()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("1: Search by Passenger's Name");
            Console.WriteLine("2: Search by Flight Date");
            Console.WriteLine("3: Search by Destination");
            Console.WriteLine("===================================");
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
