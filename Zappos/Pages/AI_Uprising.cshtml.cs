using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Zappos.Pages
{
    public class AI_UprisingModel : PageModel
    {
        private readonly ILogger<AI_UprisingModel> _logger;

        public AI_UprisingModel(ILogger<AI_UprisingModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
