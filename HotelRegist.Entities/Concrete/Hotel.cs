using HotelRegist.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRegist.Entities.Concrete
{
    public class Hotel:IEntity
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public int Price { get; set; }
        public int Capasity { get; set; }
        public int CategoryId { get; set; }
        public override string ToString()
        {
            return $"{HotelName,-10}" +
                $"{Price,-10}" +
                $"{Capasity,-10}"+
                $"{CategoryId}";
        }

    }
}
