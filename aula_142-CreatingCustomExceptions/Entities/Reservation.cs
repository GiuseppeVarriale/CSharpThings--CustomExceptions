using System;
namespace aula_142_CreatingCustomExceptions.Entities
{
    class Reservation
    {
        public int RoomNumber { get; private set; }
        public DateTime CheckIn { get; private set; }
        public DateTime CheckOut { get; private set; }

        public Reservation() 
        { 
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration() 
        {
            TimeSpan duration = CheckIn.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + Duration()
                + " nights";
        }

        public void UpdateDates(DateTime checkin, DateTime checkout) 
        {
            Console.WriteLine("not Implemented yet") ;
        }
    }
}
