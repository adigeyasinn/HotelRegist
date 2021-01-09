using HotelRegist.Abstract;
using HotelRegist.DataAccess.Abstract;
using HotelRegist.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRegist.Concrete
{
    public class HotelManager:IHotelService
    {
        private IHotelDal _hotelDal;    //Dependency İnjection

        public HotelManager(IHotelDal hotelDal)
        {
            _hotelDal = hotelDal;
        }

        public void Add(Hotel hotel)
        {
            _hotelDal.Add(hotel);
        }

        public List<Hotel> GetAll()
        {
            return _hotelDal.GetAll();
        }
    }
}
