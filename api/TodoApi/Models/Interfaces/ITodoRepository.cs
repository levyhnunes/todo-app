using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApi.Models.Interfaces
{
    interface ITodoRepository : IRepository<Todo>
    {
        List<Todo> GetByDescription(string description);
    }
}
