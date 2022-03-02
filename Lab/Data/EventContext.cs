using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab.Models;

namespace Lab.Data
{
    public class EventContext : DbContext
    {
        public EventContext (DbContextOptions<EventContext> options)
            : base(options)
        {
        }
        //Database is set to the model
        public DbSet<Event> Events { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().ToTable("Event");
            
        }

    }
}
