using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class AddSocialnetworkModel : PageModel
    {
        AppDbContext db;
        public SocialNetwork socialNetwork { get; set; }
        public AddSocialnetworkModel(AppDbContext _db)
        {
            db= _db;
        }
        public IActionResult OnGet()
        {
            var Verify = HttpContext.Session.GetString("flag");
            if (Verify == null)
            {
                return RedirectToPage("../myadmin/Login");
            }
            return Page();
        }
        public IActionResult OnPost(SocialNetwork socialNetwork )
        {
            if (ModelState.IsValid)
            {
                db.tbl_SocailNetwork.Add(socialNetwork);
                db.SaveChanges();
                return RedirectToPage("ShowSocialNetwork");

            }
            return Page();
            

        }

    }
}
