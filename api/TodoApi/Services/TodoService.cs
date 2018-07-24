using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoApi.Infra.Context;
using TodoApi.Infra.Repository;
using TodoApi.Models;
using TodoApi.Models.Interfaces;
using TodoApi.ViewModel;

namespace TodoApi.Services
{
    public class TodoService
    {
        ITodoRepository _todoRepository;

        public TodoService()
        {
            var context = new TodoContext();
            _todoRepository = new TodoRepository(context);
        }

        public List<Todo> GetByDescription(string description)
        {
            var results = _todoRepository.GetByDescription(description);

            return results;
        }

        public void SaveOrUpdate(TodoViewModel todo)
        {
            if (todo.Id != 0)
            {
                var todoAux = _todoRepository.GetById(todo.Id);
                todoAux.Description = todo.Description;
                todoAux.Done = todo.Done;
                _todoRepository.UpdateAndSave(todoAux);
            }
            else
            {
                var todoSave = new Todo()
                {
                    Description = todo.Description,
                    Done = todo.Done,
                    CreatDate = new DateTime()
                };

                _todoRepository.AddAndSave(todoSave);
            }
        }

        public void Delete(int id)
        {
            var todo = _todoRepository.GetById(id);
            _todoRepository.DeleteAndSave(todo);
        }
    }
}