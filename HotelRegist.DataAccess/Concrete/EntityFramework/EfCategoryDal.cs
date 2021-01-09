using HotelRegist.DataAccess.Abstract;
using HotelRegist.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRegist.DataAccess.Concrete.EntityFramework
{
   public class EfCategoryDal:EfRepositoryBase<Category,HotelRegistContext>,ICategoryDal
    {
    }
}
