using System;

namespace Ticket_Cost
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Adult ticket cost $3.75 and child ticket cost $2.25. Write a program to prompt the user for 
               the amount of adult and child ticket that she needs. The program will display a user-friendly
               message of the number of tickets brought as well as the total cost. (Use the "C" formatstring for currency) */
            
            //Input

            double adultTicket = 3.75, childTicket = 2.25, totalPrice;
            int totalChildTickets, totalAdultTickets;

            Console.Write("Enter The Number Of Adult Tickets: ");
            totalAdultTickets = int.Parse(Console.ReadLine());

            Console.Write("Enter The Numeber Of Child Tickets: ");
            totalChildTickets = int.Parse(Console.ReadLine());
            
            //Processing

            totalPrice = adultTicket * totalAdultTickets + childTicket * totalChildTickets;

            //Output

            Console.WriteLine();
            Console.WriteLine("Order Summary: ");
            Console.WriteLine();
            Console.WriteLine("Number Of Adult Tickets: " + totalAdultTickets + " ($3.75 Each)");
            Console.WriteLine("Number Of Child Tickets: " + totalChildTickets + " ($2.25 Each)");
            Console.WriteLine();
            Console.WriteLine($"Total Price: {totalPrice.ToString("c")}");

        }
    }
}
