using IService;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public abstract class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        DataDbContext dt = new DataDbContext();

        public DbSet<T> Entities
        {
            get { return dt.Set<T>(); }
        }

        public List<T> Index()
        {
            var list = Entities.ToList();
            return list;

        }

        public int Insert(T entity)
        {
            Entities.Add(entity);
            var i = dt.SaveChanges();
            return i;
        }

        public int Insert(IEnumerable<T> entities)
        {
            Entities.AddRange(entities);
            return dt.SaveChanges();
        }

        public int Update(T entity)
        {
            dt.Entry(entity).State = EntityState.Modified;
            return dt.SaveChanges();
        }

        public int Delete(object id)
        {
            ///删除操作实现
            var obj = Entities.Find(id);
            Entities.Remove(obj);
            return dt.SaveChanges();
        }

        public T GetModelById(object key)
        {
            var obj = Entities.Find(key);
            return obj;
        }
    }
}
