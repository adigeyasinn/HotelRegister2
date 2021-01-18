using HotelRegister1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HotelRegister1.DataAccess.Abstract
{
    public interface IHotelDal : IEntityRepository<Hotel>
    {
      
    }
}
