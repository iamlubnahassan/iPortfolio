using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class AddSkillModel : PageModel
    {
        AppDbContext db;
        public Skill skill { get; set; }
        public AddSkillModel(AppDbContext _db)
        {
             db = _db;
        }
        public IActionResult OnGet()
        {
            var Verify = HttpContext.Session.GetString("flag");
            if (Verify == null)
            {
                return RedirectToPage("../myadmin/Login");
            }
            return Page();
        }
        public IActionResult OnPost(Skill skill)
        { 
            if(ModelState.IsValid)
            {
                db.tbl_Skill.Add(skill);
                db.SaveChanges();
                return RedirectToPage("ShowSkill");
            }
            return Page();
        }
    }
}
