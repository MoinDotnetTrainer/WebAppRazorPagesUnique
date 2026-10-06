using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPagesUnique.Pages
{
    public class AdditionModel : PageModel
    {

        // on get is a method that gets executes on page load
        public void OnGet()
        {
            int x = 34;
            int y = 345;
            int z = x + y;
            TempData["res"]= z;
        }
    }
}
