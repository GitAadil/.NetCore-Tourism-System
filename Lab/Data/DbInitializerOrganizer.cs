using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab.Data
{
    public static class DbInitializerOrganizer
    {
        public static void InitializeOrganizer(OrganizerContext contextOrganizer)
        {
            contextOrganizer.Database.EnsureCreated();

            // Look for any Organizers.
            if (contextOrganizer.Organizers.Any())
            {
                return;   // DB has been seeded
            }

            var organizers = new Organizer[]
            {
                new Organizer{OrganizerName = "Victoria Univeristy", Email = "vic@gmail.com", Phone = 7894561},
                new Organizer{OrganizerName = "Monash University", Email = "Monash@gmail.com", Phone = 8794561},
                new Organizer{OrganizerName = "La Trobe University", Email = "LaTrobe@gmail.com", Phone = 6594561},
                new Organizer{OrganizerName = "RMIT Univeristy", Email = "RMIT@gmail.com", Phone = 1294561}

            };
            foreach (Organizer s in organizers)
            {
                contextOrganizer.Organizers.Add(s);
            }
            contextOrganizer.SaveChanges();
        }
    }
}
