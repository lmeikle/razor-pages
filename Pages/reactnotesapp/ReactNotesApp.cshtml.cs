using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_pages.Pages.reactnotesapp
{
    public class ReactNotesAppModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "React Notes App";
        }
    }
}
