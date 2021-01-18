using HotelRegister1.Business.Abstract;
using HotelRegister1.Business.DependencyResolvers.Ninject;
using HotelRegister1.Entities.Concrete;
using System;

namespace HotelRegister1.ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var hotelService = InstanceFactory.GetInstance<IHotelService>();
            try
            {
                //Hotel hotel = new Hotel() { HotelName = "adige", FeePerNight = 200, Stars = 3 };
                //hotelService.Add(hotel);//Ekleme
                // hotelService.Delete(new Hotel { HotelId=1002}); //Silme
                //hotelService.Update(new Hotel { HotelId =1008, HotelName = "Adige", FeePerNight = 500, Stars = 3 });
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            //var list = hotelService.Get(x=>x.HotelId==1);
            //Console.WriteLine(list);

            var list = hotelService.GetAll();
          

            foreach (var c in list)
            {
                Console.WriteLine(c);
            }



            Console.ReadLine();
        }
    }
}
