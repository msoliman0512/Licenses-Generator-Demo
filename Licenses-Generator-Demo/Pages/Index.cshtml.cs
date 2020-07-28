using Licenses_Generator_Demo.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Licenses_Generator_Demo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public GovernoratesService GovernorateService;

        public IndexModel(ILogger<IndexModel> logger,
            GovernoratesService governorateService)
        {
            _logger = logger;
            GovernorateService = governorateService;
        }

        public void OnGet()
        {
        }
    }
}