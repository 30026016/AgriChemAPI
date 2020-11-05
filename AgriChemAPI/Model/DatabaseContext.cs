using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriChemAPI.Model
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Region> Region { get; set; }
        public DbSet<Contractor> Contractor { get; set; }
        public DbSet<ContractManager> ContractManager { get; set; }
        public DbSet<AgriChemical> AgriChemical { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Method> Method { get; set; }
        public DbSet<Reason> Reason { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<AgriChemicalApplication> AgriChemicalApplication { get; set; }
    }
}
