﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_pages.Pages
{
    public class FormsModel : PageModel
    {
        public string Message { get; set; }

        [BindProperty]
        public string Name { get; set; }

        public string Id { get; set; }

        public void OnGet()
        {
            Message = "I'm the FormsModel!!";
        }

        public void OnPost()
        {
            Message = "whoop you posted form1!!";
        }

        public void OnPostForm2(string name)
        {
            Message = $"whoop you posted form2!! you posted {name}";
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
