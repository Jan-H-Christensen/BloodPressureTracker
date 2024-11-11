using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace EFramework.Data
{
    public class BPDbContext : DbContext
    {
        public BPDbContext(DbContextOptions<BPDbContext> options) : base(options) { }
        public BPDbContext() { }

        public virtual DbSet<Patients> patientsTables { get; set; }
        public virtual DbSet<Measurements> measurementsTables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}