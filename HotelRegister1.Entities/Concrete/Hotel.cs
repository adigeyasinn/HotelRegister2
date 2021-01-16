using HotelRegister1.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelRegister1.Entities.Concrete
{
    public class Hotel : IEntity
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public decimal FeePerNight { get; set; }
        public int Stars { get; set; }

        public override string ToString()
        {
            return $"{HotelId,-15}" +
                $"{HotelName,-15}" +
                $"{FeePerNight,-15}" +
                $"{Stars,-15}";
        }
    }
}
