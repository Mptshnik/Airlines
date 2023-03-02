using Airlines.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.database
{
    public class DatabaseContext : DbContext
    {
        private static DatabaseContext instance;

        public DbSet<User> Users { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Session> Sessions { get; set; }

        public DatabaseContext() : base("DefaultConnection")
        { 
        }

        public static DatabaseContext GetInstance() 
        { 
            if(instance == null)
            {
                instance = new DatabaseContext();
            }

            return instance;
        }
    }
}
