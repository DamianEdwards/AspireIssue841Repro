using AspireIssue841Repro.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspireIssue814Repro.RazorPages.Pages;

public class IndexModel(ILogger<IndexModel> logger, AdminApiClient adminApi) : PageModel
{
    private string? provider = "something";

    public int Something { get; set; }
    public int Something2s { get; set; }
    public int Something3s { get; set; }
    public int Something4s { get; set; }

    public async Task OnGetAsync()
    {
        var something = await adminApi.GetApi1();

        if (provider is null)
        {
            return;
        }

        Something = something;

        Something2s = await adminApi.GetApi2();

        Something3s = await adminApi.GetApi3();

        Something4s = await adminApi.GetApi4();
    }
}
