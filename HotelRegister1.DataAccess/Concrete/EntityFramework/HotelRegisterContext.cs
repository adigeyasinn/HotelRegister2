using HotelRegister1.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelRegister1.DataAccess.Concrete.EntityFramework
{
    public class HotelRegisterContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HotelDb; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
