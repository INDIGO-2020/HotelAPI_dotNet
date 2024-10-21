using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Domain.Model
{
    public class Hotel
    {
        public Hotel(int id, string name, int rateHotel, int myProperty)
        {
            Id = id;
            Name = name;
            RateHotel = rateHotel;
            MyProperty = myProperty;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int RateHotel { get; set; }
        public int MyProperty { get; set; }
    }
}
