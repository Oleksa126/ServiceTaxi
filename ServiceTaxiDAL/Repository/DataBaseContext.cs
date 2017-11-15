using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ServiceTaxi.Models;

namespace ServiceTaxi.Repository
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("DbConnection") { }

        public DbSet<User> Users { get; set; }

    }

}
