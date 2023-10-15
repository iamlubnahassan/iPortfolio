using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class UpdateFactsModel : PageModel
    {
        AppDbContext db;
        public Facts facts { get; set; }
        public UpdateFactsModel(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult OnGet(int Id)
        {
            facts = db.tbl_Fact.Find(Id);
            var Verify = HttpContext.Session.GetString("flag");
            if (Verify == null)
            {
                return RedirectToPage("../myadmin/Login");
            }
            return Page();
        }
        public IActionResult OnPost(Facts facts)
        { 
            db.tbl_Fact.Update(facts);
            db.SaveChanges();
            return RedirectToPage("ShowFacts");

        }
    }
}
