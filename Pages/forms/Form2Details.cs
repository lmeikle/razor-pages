using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace razor_pages.Pages
{
    public class Form2Details
    {
        [Required]
        [MinLength(6)]
        public string Name { get; set; }
    }
}
