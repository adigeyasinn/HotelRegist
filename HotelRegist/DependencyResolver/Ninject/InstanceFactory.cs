using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRegist.DependencyResolver.Ninject
{
   public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            return new StandardKernel(new BusinessModule()).Get<T>();
        }
    }
}
