using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagHelper_ViewComponent_Basics.Pages.Models;

namespace TagHelper_ViewComponent_Basics
{
    public class PopularBrews : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            List<Speaker> speakers = new List<Speaker>
{
        new Speaker
        {
            SpeakerId = 1124,
            UserFirstName = "Douglas",
            UserLastName = "Crockford",
            TrackName = "JavaScript",
            Company = "PayPal"
        },
        new Speaker
        {
            SpeakerId = 823,
            UserFirstName = "Kevin",
            UserLastName = "Nilson",
            TrackName = "JavaScript",
            Company = "Google"
        },
        new Speaker
        {
            SpeakerId = 6548,
            UserFirstName = "Steve",
            UserLastName = "Souders",
            TrackName = "JavaScript",
            Company = "SpeedCurver"
        }
        ,
        new Speaker
        {
            SpeakerId = 2920,
            UserFirstName = "Steve",
            UserLastName = "Souders",
            TrackName = "JavaScript",
            Company = "SpeedCurver"
        }
    };
            return View("Default", speakers);

        }
    }
}
