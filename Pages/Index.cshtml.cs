using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace razor_pages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            ViewData["appSettings_first"] = _configuration["AppSettings:First"];

            var settings = _configuration.GetSection("AppSettings").Get<AppSettings>();
            ViewData["appSettings_registrationDate"] = settings.Vehicle.RegistrationDate;
        }
    }
}
