using HotelRegist.Abstract;
using HotelRegist.Concrete;
using HotelRegist.DataAccess.Abstract;
using HotelRegist.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRegist.DependencyResolver.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IHotelDal>().To<EfHotelDal>().InSingletonScope();
            Bind<IHotelService>().To<HotelManager>().InSingletonScope();

            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
        }
    }
}
