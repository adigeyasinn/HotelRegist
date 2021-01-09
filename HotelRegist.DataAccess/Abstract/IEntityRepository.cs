using HotelRegist.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRegist.DataAccess.Abstract
{
   public interface IEntityRepository<T> where T:class,IEntity,new() //T bir referans tipli olmalı yani class olmalı, new lenebilmeli
    {
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
