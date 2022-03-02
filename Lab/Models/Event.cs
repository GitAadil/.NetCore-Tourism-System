using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string OrganizerName { get; set; }
        public string Date { get; set; }
        public int Duration { get; set; }
        public string SpeakerName { get; set; }
    }
}
