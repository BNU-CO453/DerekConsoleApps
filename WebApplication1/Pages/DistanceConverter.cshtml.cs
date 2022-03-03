using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleAppProject.App01;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace WebApplication1.Pages
{
    public class DistanceConverterModel : PageModel
    {
        [BindProperty]
        public DistanceConverter App01 { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            App01.Calculate();
            ViewData["Message"] = "" + App01.fromDistance + " " + App01.toDistance;
        }
    }
}
