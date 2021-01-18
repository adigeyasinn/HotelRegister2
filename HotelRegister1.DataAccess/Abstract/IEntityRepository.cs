using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HotelRegister1.DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T t);
        void Update(T t);
        void Delete(T t);

    }
}
