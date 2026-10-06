using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesUnique.Model;

namespace WebAppRazorPagesUnique.Pages
{
    public class SomeCalciModel : PageModel
    {
        [BindProperty]
        public Myvalues _myprop { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            int z = _myprop.x + _myprop.y;
            TempData["res"] = z;
        }   
    }
}
