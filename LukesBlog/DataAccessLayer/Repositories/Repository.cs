using LukesBlog.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LukesBlog.DataAccessLayer.Repositories
{
    public class Repository<T> where T : class
    {
        private BlogDBContext context = new BlogDBContext();

        protected DbSet<T> DbSet { get; set; }

        public Repository()
        {
            DbSet = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}