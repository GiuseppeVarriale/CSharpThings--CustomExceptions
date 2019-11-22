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
            Console.Write("Check-ou date (dd//MM/yyyy)): ");
            DateTime checkOutDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            Reservation reservation = new Reservation(roomNumber, checkInDate, checkOutDate);
            Console.WriteLine(reservation);

        }
    }
}
