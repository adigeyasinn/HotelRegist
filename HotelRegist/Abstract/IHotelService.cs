using HotelRegist.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRegist.Abstract
{
    public interface IHotelService
    {
        List<Hotel> GetAll();
        void Add(Hotel hotel);
    }
}
