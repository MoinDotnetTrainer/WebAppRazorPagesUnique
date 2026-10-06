using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPagesUnique.Pages
{
    public class DemoModel : PageModel
    {
        public void OnGet()
        {
            string str = null;
            int res = str.Length;
            TempData["res"] = res;
        }
    }
}
