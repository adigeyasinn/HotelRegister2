using HotelRegister1.DataAccess.Abstract;
using HotelRegister1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelRegister1.DataAccess.Concrete.EntityFramework
{
    public class EfHotelDal : EfRepositoryBase<Hotel, HotelRegisterContext>, IHotelDal
    {

    }
}
