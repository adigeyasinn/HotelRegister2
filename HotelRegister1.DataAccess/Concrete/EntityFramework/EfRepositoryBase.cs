using HotelRegister1.DataAccess.Abstract;
using HotelRegister1.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HotelRegister1.DataAccess.Concrete.EntityFramework
{
    public class EfRepositoryBase<Tentity, Tcontext> : IEntityRepository<Tentity> where Tentity : class, IEntity, new()
         where Tcontext : DbContext, new()
    {
        public void Add(Tentity t)
        {
            using (Tcontext context = new Tcontext())
            {
                context.Entry(t).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tentity t)
        {
            using (Tcontext context = new Tcontext())
            {
                context.Entry(t).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }


        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null)
        {
            using (var context = new Tcontext())
            {
                return filter == null ?
                    context.Set<Tentity>().ToList() :
                    context.Set<Tentity>().Where(filter).ToList();


            }
        }

      

        public void Update(Tentity t)
        {
            using (Tcontext context = new Tcontext())
            {
                context.Entry(t).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
