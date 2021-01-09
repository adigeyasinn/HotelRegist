using HotelRegist.Abstract;
using HotelRegist.DependencyResolver.Ninject;
using HotelRegist.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRegist.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var hotelService = InstanceFactory.GetInstance<IHotelService>();
            var hotelList = hotelService.GetAll();

            hotelList.ForEach(b => Console.WriteLine(b));

            try
            {
                var hotel = new Hotel()
                {
                    Id = 1,
                    Capasity = 2000,
                    CategoryId = 2,
                    HotelName = "GUNES HOTEL",
                    Price = 500
                };
                hotelService.Add(hotel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
