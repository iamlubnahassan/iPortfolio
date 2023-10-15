using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class ShowServiceModel : PageModel
    {
        AppDbContext db;
        public List<Service> service { get; set; }
        public ShowServiceModel( AppDbContext _db)
        {
            db=_db;
        }
        public IActionResult OnGet()
        {
            service=db.tbl_Service.ToList();
            var Verify = HttpContext.Session.GetString("flag");
            if (Verify == null)
            {
                return RedirectToPage("../myadmin/Login");
            }
            return Page();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var ItemToDel=db.tbl_Service.Find(Id);
            db.tbl_Service.Remove(ItemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowService");

        }
    }
}
