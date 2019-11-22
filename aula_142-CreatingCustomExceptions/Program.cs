using System;
using aula_142_CreatingCustomExceptions.Entities;
namespace aula_142_CreatingCustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd//MM/yyyy): ");
            DateTime checkInDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-ou date (dd//MM/yyyy): ");
            DateTime checkOutDate = DateTime.Parse(Console.ReadLine());
            if (checkOutDate <= checkInDate)
            {
                Console.WriteLine();
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkInDate, checkOutDate);
                Console.WriteLine("Reservation: " + reservation);
                
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservaion:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkInDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-ou date (dd/MM/yyyy): ");
                checkOutDate = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkInDate < now || checkOutDate < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates"); 
                }
                else if (checkOutDate <= checkInDate)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
                }
                else
                {
                    reservation.UpdateDates(checkInDate, checkOutDate);
                }

            }

        }
    }
}
