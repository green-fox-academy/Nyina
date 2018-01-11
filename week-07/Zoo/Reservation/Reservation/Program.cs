using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    class ReservationApp
    {
        static void Main(string[] args)
        {
            var reservation = new Reservation();

            Console.WriteLine("Booking# {0} for {1}", reservation.GetRandomString(), reservation.DOW());

            Console.ReadLine();
        }

    }
}
