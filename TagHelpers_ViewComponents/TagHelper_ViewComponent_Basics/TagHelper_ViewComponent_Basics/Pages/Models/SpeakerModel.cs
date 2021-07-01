using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelper_ViewComponent_Basics.Pages.Models
{
    public class Speaker
    {
        public int SpeakerId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string Company { get; set; }
        public string TrackName { get; set; }
    }
}
