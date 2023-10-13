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
        public void OnGet()
        {
        }
        public IActionResult OnPost(Skill skill)
        { 
            db.tbl_Skill.Add(skill);
            db.SaveChanges();
            return RedirectToPage("ShowSkill");
        }
    }
}
