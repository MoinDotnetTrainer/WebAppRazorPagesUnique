using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPagesUnique.Pages
{
    public class MulModel : PageModel
    {
        [BindProperty]
        public int val1 { get; set; }

        [BindProperty]
        public int val2 { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
          
            int z = val1 * val2;
            TempData["res"] = z;
        }
    }
}
