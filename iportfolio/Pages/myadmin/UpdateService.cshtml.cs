using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class UpdateServiceModel : PageModel
    {
        AppDbContext db;
        public Service service { get; set; }
        public UpdateServiceModel(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult OnGet(int Id)
        {
            service = db.tbl_Service.Find(Id);
            var Verify = HttpContext.Session.GetString("flag");
            if (Verify == null)
            {
                return RedirectToPage("../myadmin/Login");
            }
            return Page();
        }
        public IActionResult OnPost(Service service)
        { 
            db.tbl_Service.Update(service);
            db.SaveChanges();
            return RedirectToPage("ShowService");
        }
    }
}
