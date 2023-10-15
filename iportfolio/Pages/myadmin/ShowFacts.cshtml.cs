using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class ShowFactsModel : PageModel
    {
        AppDbContext db;
        public List<Facts> facts{ get; set; }
        public ShowFactsModel(AppDbContext _db)
        {
            db=_db;
        }
        public IActionResult OnGet()
        {
            facts = db.tbl_Fact.ToList();
            var Verify = HttpContext.Session.GetString("flag");
            if (Verify == null)
            {
                return RedirectToPage("../myadmin/Login");
            }
            return Page();
        }
        public IActionResult OnGetDelete(int Id) 
        {
            var ItemToDel = db.tbl_Fact.Find(Id);
            db.tbl_Fact.Remove(ItemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowFacts");


        }
    }
}
