using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiCRUDDemo.Models;

namespace WebApiCRUDDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("WebApiCrudDBConn") {}

        public DbSet<Employee> Employees { get; set; }
    }
}