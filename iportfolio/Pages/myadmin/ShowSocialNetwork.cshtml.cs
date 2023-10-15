using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class ShowSocialNetworkModel : PageModel
    {
        AppDbContext db;
        public List<SocialNetwork> socialNetworks { get; set; }
        public ShowSocialNetworkModel(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult OnGet()
        {
            socialNetworks =db.tbl_SocailNetwork.ToList();
            var Verify = HttpContext.Session.GetString("flag");
            if (Verify == null)
            {
                return RedirectToPage("../myadmin/Login");
            }
            return Page();
        }
        public IActionResult OnGetDelete(int Id) 
        {
           var ItemToDel= db.tbl_SocailNetwork.Find(Id);
            db.tbl_SocailNetwork.Remove(ItemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowSocialNetwork");
        }
    }
}
