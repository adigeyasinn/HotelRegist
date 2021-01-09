using HotelRegist.DataAccess.Abstract;
using HotelRegist.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRegist.DataAccess.Concrete.EntityFramework
{
    public class EfRepositoryBase<Tentity, Tcontext> : IEntityRepository<Tentity> 
        where Tentity:class,IEntity,new() 
        where Tcontext:DbContext,new()
    {
        public void Add(Tentity entity)
        {
            using (var context=new Tcontext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tentity entity)
        {
            using (var context=new Tcontext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Tentity> GetAll()
        {
            using (var context = new Tcontext())
            {
                return context.Set<Tentity>().ToList();
            }
        }

        public void Update(Tentity entity)
        {
            using (var context=new Tcontext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
