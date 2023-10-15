using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class AddExperienceModel : PageModel
    {
        AppDbContext db;
        public Experience experience { get; set; }
        public AddExperienceModel( AppDbContext _db)
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
        public IActionResult OnPost(Experience experience)
        { 
            if(ModelState.IsValid)
            {
                db.tbl_Experience.Add(experience);
                db.SaveChanges();
                return RedirectToPage("ShowExperience");

            }
            return Page();
            
        }
    }
}
