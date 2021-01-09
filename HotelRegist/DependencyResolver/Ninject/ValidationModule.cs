using FluentValidation;
using HotelRegist.Entities.Concrete;
using HotelRegist.Entities.ValidationRules.FluentValidation;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRegist.DependencyResolver.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Hotel>>().To<HotelValidator>().InSingletonScope();
        }
    }
}
