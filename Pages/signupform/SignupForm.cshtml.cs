using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using razor_pages.Pages;

namespace razor_pages.Pages
{
    public class SignupFormModel : PageModel
    {
        public string Message { get; set; }

        [BindProperty]
        public UserDetails UserDetails { get; set; }

        public void OnGet()
        {
            Message = "Signup Form page";
        }

        // The old way
        /**public void OnPost()
        {
            var name = Request.Form["Name"];
            var email = Request.Form["Email"];
            ViewData["confirmation"] = $"{name}, information will be sent to {email}";
        }*/

        // Binding Posted Form Values To Handler Method Parameters
        /**public void OnPost(string name, string email)
        {
            ViewData["confirmation"] = $"{name}, information will be sent to {email}";
        }*/

        //Binding Posted Form Values to PageModel Properties
        public void OnPost()
        {
            Message = "Signup Form page";

            ViewData["confirmation"] = $"{UserDetails.Name}, information will be sent to {UserDetails.Email}";
        }
    }
}
