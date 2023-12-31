using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class AddServiceModel : PageModel
    {
        AppDbContext db;
        public Service service { get; set; }
        public AddServiceModel( AppDbContext _db)
        {
            db=_db;
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
        public IActionResult OnPost(Service service)
        {
            if(ModelState.IsValid)
            {
                db.tbl_Service.Add(service);
                db.SaveChanges();
                return RedirectToPage("ShowService");

            }
            return Page();
        }
    }
}
