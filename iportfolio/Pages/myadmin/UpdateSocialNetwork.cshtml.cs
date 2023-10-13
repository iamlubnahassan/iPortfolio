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
        public void OnGet(int id)
        {
            socialNetwork = db.tbl_SocailNetwork.Find(id);
        }
        public IActionResult OnPost( SocialNetwork socialNetwork)
        {
            db.tbl_SocailNetwork.Update( socialNetwork );
            db.SaveChanges();
            return RedirectToPage("ShowSocialNetwork");
        }
    }
}
