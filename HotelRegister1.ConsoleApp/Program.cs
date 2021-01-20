using HotelRegister1.Business.Abstract;
using HotelRegister1.Business.DependencyResolvers.Ninject;
using HotelRegister1.Entities.Concrete;
using System;
using System.Linq;

namespace HotelRegister1.ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var hotelService = InstanceFactory.GetInstance<IHotelService>();


            var list = hotelService.GetAll().OrderBy(s => s.HotelName).ToList();
          

            foreach (var c in list)
            {
                Console.WriteLine(c);
            }



            Console.ReadLine();
        }
    }
}
