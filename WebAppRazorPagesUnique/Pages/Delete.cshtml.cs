using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesUnique.Model;

namespace WebAppRazorPagesUnique.Pages
{
    public class DeleteModel : PageModel
    {
        Appdb _db;
        public DeleteModel() {
            _db = new Appdb();
        }

        [BindProperty]
        public UsersModel _User { get; set; }

        public IActionResult OnGet(int UserID)
        {
            _User = _db.Users.FirstOrDefault(x=>x.ID==UserID);
            if (_User != null)
            {
                return Page();
            }
            return RedirectToPage("/DisplayPage");
        }

        public IActionResult OnPost(int UserID) {
            var FoundRec = _db.Users.Find(UserID);
            if (FoundRec != null)
            {
                _db.Users.Remove(FoundRec);
                _db.SaveChanges();
                return RedirectToPage("/DisplayPage");
            }
            return Page();
        }
    }
}
