using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApi.Models.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IQueryable<T> All();
        void Add(T entity);
        void AddAndSave(T entity);
        void Update(T entity);
        void UpdateAndSave(T entity);
        void Delete(T entity);
        void DeleteAndSave(T entity);
    }
}
