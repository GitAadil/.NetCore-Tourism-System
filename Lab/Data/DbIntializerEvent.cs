using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab.Data
{
    public static class DbIntializerEvent
    {
        public static void InitializeEvent(EventContext contextEvent)
        {
            contextEvent.Database.EnsureCreated();

            // Look for any Events.
            if (contextEvent.Events.Any())
            {
                return;   // DB has been seeded
            }

            var events = new Event[]
            {
                new Event{EventName = "Travel Discussion", OrganizerName = "Victoria UNiversity", Date = "05/05/2020", Duration = 50, SpeakerName = "Prof Kim"},
                 new Event{EventName = "Floral Visit", OrganizerName = "Monash University", Date = "06/05/2020", Duration = 40, SpeakerName = "Prof Lucas"},
                  new Event{EventName = "Melbourne City", OrganizerName = "La Trobe University", Date = "03/05/2020", Duration = 45, SpeakerName = "Dr Lee"},
                   new Event{EventName = "Cultural Activity", OrganizerName = "RMIT University", Date = "02/05/2020", Duration = 50, SpeakerName = "Prof Merry"}

            };
            foreach (Event s in events)
            {
                contextEvent.Events.Add(s);
            }
            contextEvent.SaveChanges();
        }
    }
}

