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
        public void OnGet()
        {

        }
        public IActionResult OnPost(Experience experience)
        { 
            db.tbl_Experience.Add(experience);
            db.SaveChanges();
            return RedirectToPage("ShowExperience");
        }
    }
}
