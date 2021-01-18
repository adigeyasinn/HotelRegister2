using HotelRegister1.Business.Abstract;
using HotelRegister1.DataAccess.Abstract;
using HotelRegister1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HotelRegister1.Business.Concrete
{
    public class HotelManager : IHotelService
    {
        IHotelDal _hotelDal; //dependency injection

        public HotelManager(IHotelDal hotelDal)
        {
            _hotelDal = hotelDal;
        }

        public void Add(Hotel hotel)
        {
            _hotelDal.Add(hotel);
        }

        public void Delete(Hotel hotel)
        {
            _hotelDal.Delete(hotel);
        }

        public Hotel Get(Expression<Func<Hotel, bool>> filter)
        {
            return _hotelDal.Get(filter);
        }

        public List<Hotel> GetAll()
        {
            return _hotelDal.GetAll();
        }

       


        public void Update(Hotel hotel)
        {
            _hotelDal.Update(hotel);
        }
    }
}
