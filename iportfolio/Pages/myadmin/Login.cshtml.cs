using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class LoginModel : PageModel
    {
        AppDbContext db;
        public Login login { get; set; }
        public LoginModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost(Login login) 
        {
            var Result = db.tbl_Login.Where(opt => opt.UserName == login.UserName && opt.Password == login.Password);
            if(Result != null )
            {
                HttpContext.Session.SetString("flag", "true");
                return RedirectToPage("../myadmin/Index");
            }
            return Page();
        }
    }
}
