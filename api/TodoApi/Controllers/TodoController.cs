using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    public class TodoController : ApiController
    {
        public IHttpActionResult Get(string description)
        {
            var result = new object[] 
            { 
                new 
                { 
                    Id = 1, 
                    Description = "Teste 1",
                    Done = true
                },
                new 
                { 
                    Id = 2, 
                    Description = "Teste 2",
                    Done = false
                }
            };
            return Ok(result);
        }

        public IHttpActionResult Post(TodoViewModel todoViewModel)
        {
            return Ok();
        }

        public IHttpActionResult Put(TodoViewModel todoViewModel)
        {
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}