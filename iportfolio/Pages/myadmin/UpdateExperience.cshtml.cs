using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class UpdateExperienceModel : PageModel
    {
        AppDbContext db;
        public Experience experience { get; set; }
        public UpdateExperienceModel(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult OnGet(int Id)
        {
            experience = db.tbl_Experience.Find(Id);
            var Verify = HttpContext.Session.GetString("flag");
            if (Verify == null)
            {
                return RedirectToPage("../myadmin/Login");
            }
            return Page();
        }
        public IActionResult OnPost(Experience experience)
        {
            db.tbl_Experience.Update(experience);
            db.SaveChanges();
            return RedirectToPage("ShowExperience");
        }
    }
}
