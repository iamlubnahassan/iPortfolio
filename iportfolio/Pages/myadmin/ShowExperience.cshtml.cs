using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class ShowExperienceModel : PageModel
    {
        AppDbContext db;
        public List<Experience> experience { get; set; }
        public ShowExperienceModel(AppDbContext _db)
        {
           db=_db; 
        }
        public IActionResult OnGet()
        {
            experience = db.tbl_Experience.ToList();
            var Verify = HttpContext.Session.GetString("flag");
            if (Verify == null)
            {
                return RedirectToPage("../myadmin/Login");
            }
            return Page();

        }
        public IActionResult OnGetDelete(int Id)
        {
            var ItemToDelete = db.tbl_Experience.Find(Id);
            db.tbl_Experience.Remove(ItemToDelete);
            db.SaveChanges();
            return RedirectToPage("ShowExperience");

        }
    }
}
