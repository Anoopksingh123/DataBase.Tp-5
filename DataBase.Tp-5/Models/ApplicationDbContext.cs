using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataBase.Tp_5.Models;

namespace DataBase.Tp_5.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        { }

        public DbSet<Location> Location { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public object Locations { get; internal set; }
    }
}
                                                          