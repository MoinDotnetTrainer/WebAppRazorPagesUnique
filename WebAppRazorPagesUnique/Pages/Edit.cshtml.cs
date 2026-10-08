using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesUnique.Model;

namespace WebAppRazorPagesUnique.Pages
{
    public class EditModel : PageModel
    {
        Appdb _db;
        public EditModel()
        {
            _db = new Appdb();
        }
        [BindProperty]
        public UsersModel _users { get; set; }
        public IActionResult OnGet(int UserID)
        {
            _users = _db.Users.Find(UserID);

            if (_users == null)
            {
                return RedirectToPage("/DisplayPage");
            }

            return Page();
        }

        public IActionResult OnPost() {
            if (_users!=null)
            {
                _db.Users.Update(_users);
                _db.SaveChanges();
                return RedirectToPage("/DisplayPage");
            }
            return Page();
        }
    }
}
