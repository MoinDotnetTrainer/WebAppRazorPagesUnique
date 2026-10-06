using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPagesUnique.Pages
{
    public class SubModel : PageModel
    {

        // exe on Load
        public void OnGet()
        {
        }

        // on submit button click

        public void OnPost()
        {
            int x =Convert.ToInt32( Request.Form["val1"].ToString()); // name field in the form
            int y =Convert.ToInt32( Request.Form["val2"].ToString());

            int z = x - y;
            TempData["res"] = z;
        }
    }
}
