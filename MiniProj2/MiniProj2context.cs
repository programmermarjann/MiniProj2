using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProj2
{
    class MiniProj2context : DbContext
    {
        public DbSet<Laptop> laptops { get; set; }
        public DbSet<MobilePhone> mobilePhones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source= (localdb)\MSSQLLocalDB; Initial Catalog=MiniProj2");
        }
    }
}
