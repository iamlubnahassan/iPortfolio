using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class UpdateEducationModel : PageModel
    {
        AppDbContext db;
        public Education education { get; set; }
        public UpdateEducationModel( AppDbContext _db)
        {
            db=_db;
        }
        public IActionResult OnGet( int Id)
        {
            education = db.tbl_Education.Find(Id);
            var Verify = HttpContext.Session.GetString("flag");
            if (Verify == null)
            {
                return RedirectToPage("../myadmin/Login");
            }
            return Page();

        }
        public IActionResult OnPost( Education education) 
        { 
            db.tbl_Education.Update(education);
            db.SaveChanges();
            return RedirectToPage("ShowEducation");
        }
    }
}
