using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TodoApi.Infra.Context;
using TodoApi.Models.Interfaces;

namespace TodoApi.Infra.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        TodoContext context;

        public Repository(TodoContext context)
        {
            this.context = context;
        }


        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IQueryable<T> All()
        {
            return context.Set<T>() as IQueryable<T>;
        }

        public void Add(T entidade)
        {
            context.Entry<T>(entidade).State = System.Data.Entity.EntityState.Added;
        }

        public void AddAndSave(T entidade)
        {
            this.Add(entidade);
            context.SaveChanges();
        }

        public void Update(T entidade)
        {
            context.Entry<T>(entidade).State = System.Data.Entity.EntityState.Modified;
        }

        public void UpdateAndSave(T entidade)
        {
            this.Update(entidade);
            context.SaveChanges();
        }

        public void Delete(T entidade)
        {
            context.Entry<T>(entidade).State = System.Data.Entity.EntityState.Deleted;
        }

        public void DeleteAndSave(T entidade)
        {
            this.Delete(entidade);
            context.SaveChanges();
        }
    }
}