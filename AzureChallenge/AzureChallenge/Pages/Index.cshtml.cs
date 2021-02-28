using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureChallenge.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            TimeZoneInfo sudanTimeId = TimeZoneInfo.FindSystemTimeZoneById("Sudan Standard Time");
            DateTime currentTime = DateTime.Now;
            DateTime southSudan = TimeZoneInfo.ConvertTime(currentTime, TimeZoneInfo.Local, sudanTimeId);
            string southSudanTime = southSudan.ToString("hh:mm tt");

            ViewData["SouthSudanTime"] = southSudanTime;
        }
    }
}
