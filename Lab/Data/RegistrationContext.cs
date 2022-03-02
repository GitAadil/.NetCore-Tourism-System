using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab.Models;

namespace Lab.Data
{
    public class RegistrationContext : DbContext
    {
        public RegistrationContext (DbContextOptions<RegistrationContext> options)
            : base(options)
        {
        }
        //Database is set to the model
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>().ToTable("Registration");
        }
    }
}
