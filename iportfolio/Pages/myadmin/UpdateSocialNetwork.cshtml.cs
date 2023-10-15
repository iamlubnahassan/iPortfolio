using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class UpdateSocialNetworkModel : PageModel
    {
        AppDbContext db;
        public SocialNetwork socialNetwork { get; set; }


        public UpdateSocialNetworkModel(AppDbContext _db )
        {
            db= _db;    
        }
        public IActionResult OnGet(int id)
        {
            socialNetwork = db.tbl_SocailNetwork.Find(id);
            var Verify = HttpContext.Session.GetString("flag");
            if (Verify == null)
            {
                return RedirectToPage("../myadmin/Login");
            }
            return Page();
        }
        public IActionResult OnPost( SocialNetwork socialNetwork)
        {
            db.tbl_SocailNetwork.Update( socialNetwork );
            db.SaveChanges();
            return RedirectToPage("ShowSocialNetwork");
        }
    }
}
