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

        public void OnGet()
        {

        }
        public IActionResult OnPost( Education education)
        {
            db.tbl_Education.Add(education);
            db.SaveChanges();
            return RedirectToPage("ShowFacts");

        }
    }
}