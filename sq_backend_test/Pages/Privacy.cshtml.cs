using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace backend_test.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
        ViewData["TimeStamp"] = 5 + 5;
    }
}

