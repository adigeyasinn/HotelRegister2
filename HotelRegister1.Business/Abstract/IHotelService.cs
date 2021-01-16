using HotelRegister1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelRegister1.Business.Abstract
{
    public interface IHotelService
    {
        List<Hotel> GetAll();
        void Add(Hotel hotel);
        void Delete(Hotel hotel);
        void Update(Hotel hotel);

    }
}
