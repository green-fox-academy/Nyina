using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    public class Reservation
    {

        public string GetCodeBooking;

        public string GetDowBooking;

        // https://stackoverflow.com/questions/15249138/pick-random-char

        public static String GetRandomString()
        {
            var allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            var length = 15;

            var chars = new char[length];
            var rd = new Random();

            for (var i = 0; i < length; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new String(chars);
        }

        //Please note that the reservation code should contain 8 characters randomly from 0-Z, all uppercase letters.
        //Also, the DOW is randomly ordered to the bookings from an array.
        //DOW stands for Day of the Week (MON, TUE, etc.)

        //Output : Booking# 1WBA3OMU for THU
    }
}
