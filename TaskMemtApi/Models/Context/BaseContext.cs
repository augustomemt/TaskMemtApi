using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskMemtApi.Models.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext()
        {

        }
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }

        public DbSet<Departament> Departaments { get; set; }
        public DbSet<Employees> Employees { get; set; }

        public DbSet<PerformanceArea> PerformanceAreas { get; set; }

        public DbSet<Schedules> Schedules { get; set; }

        public DbSet<Task> Tasks { get; set; }
    }
}
