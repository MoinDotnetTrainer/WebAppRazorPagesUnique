using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesUnique.Model;

namespace WebAppRazorPagesUnique.Pages
{
    public class DisplayPageModel : PageModel
    {
        Appdb _db;
        public DisplayPageModel()
        {
            _db = new Appdb();
        }


        // List , Sorted set , stack
        public IList<UsersModel> _Users { get; set; }
        public void OnGet() // on load
        {
            _Users = (from s in _db.Users select s).ToList();
        }
    }
}
