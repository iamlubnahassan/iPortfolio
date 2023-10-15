using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class ShowSkillModel : PageModel
    {
        AppDbContext db;
        public  List<Skill> skill { get; set; }
        public ShowSkillModel(AppDbContext _db)
        {
            db= _db;
        }
        public IActionResult OnGet()
        {
            skill= db.tbl_Skill.ToList();
            var Verify = HttpContext.Session.GetString("flag");
            if (Verify == null)
            {
                return RedirectToPage("../myadmin/Login");
            }
            return Page();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var ItemToDel = db.tbl_Skill.Find(Id);
            db.tbl_Skill.Remove(ItemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowSkill");

        }
    }
}
