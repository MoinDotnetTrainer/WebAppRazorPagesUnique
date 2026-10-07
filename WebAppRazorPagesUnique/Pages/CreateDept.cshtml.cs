using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesUnique.Model;

namespace WebAppRazorPagesUnique.Pages
{
    public class CreateDeptModel : PageModel
    {

        Appdb _db;
        public CreateDeptModel()
        {
            _db = new Appdb();
        }   

        [BindProperty]
        public DeptModel _dept { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() {

            _db.Dept.Add(_dept);
            _db.SaveChanges();
            return RedirectToPage("/Homepage");
        }
    }
}
