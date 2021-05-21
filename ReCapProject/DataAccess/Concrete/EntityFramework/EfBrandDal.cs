using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (ReCapProjectContext reCapProjectContext=new ReCapProjectContext())
            {
                var addedEntity = reCapProjectContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                reCapProjectContext.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (ReCapProjectContext reCapProjectContext = new ReCapProjectContext())
            {
                var deletedEntity = reCapProjectContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                reCapProjectContext.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (ReCapProjectContext reCapProjectContext = new ReCapProjectContext())
            {
                return reCapProjectContext.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (ReCapProjectContext reCapProjectContext = new ReCapProjectContext())
            {
                return filter == null
                    ? reCapProjectContext.Set<Brand>().ToList()
                    : reCapProjectContext.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
        {
            using (ReCapProjectContext reCapProjectContext = new ReCapProjectContext())
            {
                var modifiedEntity = reCapProjectContext.Entry(entity);
                modifiedEntity.State = EntityState.Modified;
                reCapProjectContext.SaveChanges();
            }
        }
    }
}
