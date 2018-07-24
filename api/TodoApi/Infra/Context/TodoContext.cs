using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using TodoApi.Models;

namespace TodoApi.Infra.Context
{
    public class TodoContext : DbContext
    {
        public TodoContext()
            : base("StringConn")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;

            Database.CommandTimeout = 300;

            Database.SetInitializer<TodoContext>(null);
        }

        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}