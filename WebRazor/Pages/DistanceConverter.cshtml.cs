using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleAppProject.App01;

namespace WebRazor.Pages
{
    public class DistanceConverterModel : PageModel
    {
        [BindProperty]
        public DistanceConverter App01 { get; set; }
        
        private readonly ILogger<DistanceConverterModel> _logger;

        public DistanceConverterModel(ILogger<DistanceConverterModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
