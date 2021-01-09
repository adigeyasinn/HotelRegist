using HotelRegist.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRegist.DataAccess.Concrete.EntityFramework
{
    public class HotelRegistContext:DbContext
    {
        public HotelRegistContext()
        {
            Database.SetInitializer<HotelRegistContext>(null);
        }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
