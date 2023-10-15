using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class AddEducationModel : PageModel
    {
        AppDbContext db;
        public Education education { get; set; }
        public AddEducationModel(AppDbContext _db)
        {
            db = _db;
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
        public IActionResult OnPost( Education education)
        {
            if(ModelState.IsValid)
            {
                db.tbl_Education.Add(education);
                db.SaveChanges();
                return RedirectToPage("ShowFacts");


            }
            return Page();

        }
    }
}
