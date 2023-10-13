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
        public void OnGet()
        {
            socialNetworks =db.tbl_SocailNetwork.ToList();
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
