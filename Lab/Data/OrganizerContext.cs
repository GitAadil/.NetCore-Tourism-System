using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab.Models;

namespace Lab.Data
{
    public class OrganizerContext : DbContext
    {
        public OrganizerContext (DbContextOptions<OrganizerContext> options)
            : base(options)
        {
        }
        //Database is set to the model
        public DbSet<Organizer> Organizers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organizer>().ToTable("Organizer");
        }
    }
}
