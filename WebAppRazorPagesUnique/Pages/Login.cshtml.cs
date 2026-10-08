using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesUnique.Model;

namespace WebAppRazorPagesUnique.Pages
{
    public class LoginModel : PageModel
    {
        Appdb _db;
        public LoginModel()
        {
            _db = new Appdb();
        }

        [BindProperty]
        public UserLoginModel _login { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Login ops , Email and password which i pass should match with the email and password from db table
            // ef core also supports linq syntax

     

            bool res = _db.Users.Any(x => x.Email == _login.Email && x.Password == _login.Password);
            
            
            if(res)
                {
                return RedirectToPage("/Homepage");
            }
            else
            {
                ViewData["msg"] = "Invalid Email or Password";
                return Page();
            }
        }
    }
}
