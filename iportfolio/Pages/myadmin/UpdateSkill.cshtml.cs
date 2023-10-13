using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class UpdateSkillModel : PageModel
    {
        AppDbContext db;
        public Skill skill { get; set; }
        public UpdateSkillModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            skill = db.tbl_Skill.Find(Id);
        }
        public IActionResult OnPost(Skill skill) 
        { 
            db.tbl_Skill.Update(skill);
            db.SaveChanges();
            return RedirectToPage("ShowSkill");
        }
    }
}
