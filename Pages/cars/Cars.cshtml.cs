using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging;

namespace razor_pages.Pages
{
    public class CarsModel : PageModel
    {
        private ILogger<CarsModel> Logger { get; set; }

        public string Message { get; set; }

        public CarsModel(ILogger<CarsModel> logger)
        {
            this.Logger = logger;
        }

        public void OnGet()
        {
            Logger.LogInformation("%%%%%%%%%%%%%%%%%%%%%%%%%%%%");

            Message = "Cars page.";
        }

        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public int Doors { get; set; }
        public int Price { get; set; }
    }
}