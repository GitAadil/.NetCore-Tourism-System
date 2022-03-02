using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RegistrationContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Registrations.
            if (context.Registrations.Any())
            {
                return;   // DB has been seeded
            }

            var registrations = new Registration[]
            {
                new Registration { FristName = "Amanda", LastName = "Roberts", EventName = "Travel Discussion", Email = "A@gmail.com" },
                new Registration { FristName = "Micheal", LastName = "Sobs", EventName = "Floral Visit", Email = "M@gmail.com" },
                new Registration { FristName = "Tony", LastName = "Barb", EventName = "Melbourne City", Email = "T@gmail.com" },
                new Registration { FristName = "Jeneane", LastName = "Anjela", EventName = "Cultural Activity", Email = "J@gmail.com" }
            };
            //New data added
            foreach (Registration s in registrations)
            {
                context.Registrations.Add(s);
            }
            context.SaveChanges();


        }
    }
}
