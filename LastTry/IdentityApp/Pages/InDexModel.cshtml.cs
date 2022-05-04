using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.Pages
{
    public class InDexModel : PageModel
    {
        private readonly ILogger<InDexModel> _logger;

        public InDexModel(ILogger<InDexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
