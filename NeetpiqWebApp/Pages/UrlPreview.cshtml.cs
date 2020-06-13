using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace NeetpiqWebApp.Pages
{
    public class UrlPreviewModel : PageModel
    {
        private readonly ILogger<UrlPreviewModel> _logger;

        public UrlPreviewModel(ILogger<UrlPreviewModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string url)
        {
            _logger.LogInformation($"Serving UrlPreview Page with url: {url}");
        }
    }
}