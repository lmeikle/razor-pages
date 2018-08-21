using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace razor_pages.Pages
{
    public class FormsModel : PageModel
    {
        public string Message { get; set; }

        [BindProperty]
        [Required]
        [MinLength(6)]
        public string Name { get; set; }

        public string Id { get; set; }

        // Server side validation did not work outless I pulled out variables into its own object!!
        [BindProperty]
        public Form2Details Form2Details { get; set; }

        public void OnGet()
        {
            Message = "I'm the FormsModel!!";
        }

        public void OnPost()
        {
            Message = "whoop you posted form1!!";
        }

        public void OnPostForm2()
        {
            Message = $"whoop you posted form2!! you posted {Form2Details.Name}";
        }

        public void OnPostRegister()
        {
            Message = $"whoop you clicked Register";
        }

        public void OnPostRequestInfoWithRouteId(string id)
        {
            Id = id;
            Message = $"whoop you clicked RequestInfoWithRouteId with id: {id}";
        }

        public void OnPostRequestInfoWithName(string id)
        {
            Id = id;
            Message = $"whoop you clicked RequestInfoWithName with id: {id}";
        }

        public RedirectToPageResult OnPostGoHome()
        {
            return new RedirectToPageResult("../Index");
            //return RedirectToPage("../Index");
        }
    }
}
