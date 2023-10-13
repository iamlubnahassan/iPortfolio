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
        public void OnGet(int Id)
        {
            experience = db.tbl_Experience.Find(Id);
        }
        public IActionResult OnPost(Experience experience)
        {
            db.tbl_Experience.Update(experience);
            db.SaveChanges();
            return RedirectToPage("ShowExperience");
        }
    }
}
