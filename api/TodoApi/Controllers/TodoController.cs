using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TodoApi.Services;
using TodoApi.ViewModel;

namespace TodoApi.Controllers
{
    public class TodoController : ApiController
    {
        TodoService _todoService;

        public TodoController()
        {
            _todoService = new TodoService();
        }

        public IHttpActionResult Get(string description)
        {
            return Ok(_todoService.GetByDescription(description));
        }

        public IHttpActionResult Post(TodoViewModel todoViewModel)
        {
            _todoService.SaveOrUpdate(todoViewModel);
            return Ok();
        }

        public IHttpActionResult Put(TodoViewModel todoViewModel)
        {
            _todoService.SaveOrUpdate(todoViewModel);
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            _todoService.Delete(id);
            return Ok();
        }
    }
}