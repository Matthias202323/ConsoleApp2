using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SavingContext : DbContext // DbContext overriden
    {
        // Product entites can be accessed by this context
        public virtual DbSet<Person> Person { get; set; }
        // Shop entities can be accessed by this context
        public virtual DbSet<SavingAccount> SavingAccount { get; set; }

        // OnConfiguring is a hook that executes while the context configures itself
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // I add a connection to a database instance while the context configures
            optionsBuilder.UseSqlServer(
                @"Server=127.0.0.1;Database=Savings;user id=sa;pwd=Toto123*;TrustServerCertificate=True;MultipleActiveResultSets=true;Integrated Security=False");
        }
    }
}
