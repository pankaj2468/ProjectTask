using Microsoft.EntityFrameworkCore;
using ProjectTask.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTask.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        //public DbSet<VMSpecialCollectionSearch> VMSpecialCollectionSearch { get; set; }

    }
}
