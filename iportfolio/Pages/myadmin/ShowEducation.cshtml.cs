using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class ShowEducationModel : PageModel
    {
        AppDbContext db;
        public List<Education> education { get; set; }
        public ShowEducationModel( AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult OnGet()
        {
            education=db.tbl_Education.ToList();
            var Verify = HttpContext.Session.GetString("flag");
            if (Verify == null)
            {
                return RedirectToPage("../myadmin/Login");
            }
            return Page();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var ItemToDel = db.tbl_Education.Find(Id);
            db.tbl_Education.Remove(ItemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowEducation");
        }
    }
}
