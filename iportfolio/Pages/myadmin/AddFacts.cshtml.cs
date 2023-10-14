using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class AddFactsModel : PageModel
    {
        AppDbContext db;
        public Facts facts { get; set; }
        public AddFactsModel(AppDbContext _db)
        {
            db = _db;   
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Facts facts)
        {
            if(ModelState.IsValid)
            {
                db.tbl_Fact.Add(facts);
                db.SaveChanges();
                return RedirectToPage("ShowFacts");

            }
            return Page();

        }
    }
}
