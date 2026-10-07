using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesUnique.Model;

namespace WebAppRazorPagesUnique.Pages
{
    public class RegisterModel : PageModel
    {

        Appdb _db;
        public RegisterModel()
        {
            _db = new Appdb();
        }

        [BindProperty]
        public UsersModel _user { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            // IactionResult --> redirectd to a page
            // 
            // trabsferd to db using ef core
            // ORM
            // Object relation mapper
            // Code first approach
            // Database first approach

            // without worring about db schame , table fields
            // Ef mapp ur c# entity with db
            // Class & methods

            // ef got certain class and methods --> mapping C# with db

            //Dll file , package 
            //1.Download these from nuget package manager
            //1.Microsoft.EntityFrameworkCore.Relational
            //2.Microsoft.EntityFrameworkCore.SqlServer
            //3.Microsoft.EntityFrameworkCore.Tools
            // select 8th latest version

            // Ef 1. Dbcontext class --> est the db connection , by passing connection string

            _db.Users.Add(_user);  // Insert ops
            _db.SaveChanges(); // Commit 
            return RedirectToPage("/Login");

        }
    }
}
