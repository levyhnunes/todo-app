using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoApi.Infra.Context;
using TodoApi.Models;
using TodoApi.Models.Interfaces;

namespace TodoApi.Infra.Repository
{
    public class TodoRepository : Repository<Todo>, ITodoRepository
    {
        TodoContext context;

        public TodoRepository(TodoContext context)
            :base(context)
        {
            this.context = context;
        }

        public List<Todo> GetByDescription(string description)
        {
            return All().Where(x => x.Description.Contains(description)).ToList();
        }
    }
}