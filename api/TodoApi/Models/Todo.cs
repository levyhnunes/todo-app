using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoApi.Models
{
    public class Todo
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public bool Done { get; set; }

        public DateTime CreatDate { get; set; }
    }
}