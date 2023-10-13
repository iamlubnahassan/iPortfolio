using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages
{
    public class IndexModel : PageModel
    {
        AppDbContext db;
        public Profoil profoil { get; set; }
        public Facts facts { get; set; }
        public List<Skill> skill { get; set; }
        public List<Education> education { get; set; }
        public List<Experience> experience { get; set; }
        public List<Service> service { get; set; }
        public List<Testimonial> testimonial { get; set; }
        public Contact contact { get; set; }
        public SocialNetwork socialNetwork { get; set; }
        public IndexModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            profoil = db.tbl_Profoil.FirstOrDefault();
            facts= db.tbl_Fact.FirstOrDefault();
            skill=db.tbl_Skill.ToList();
            education =db.tbl_Education.ToList();
            experience =db.tbl_Experience.ToList();
            service = db.tbl_Service.ToList();
            testimonial=db.tbl_testimonial.ToList();
            socialNetwork = db.tbl_SocailNetwork.FirstOrDefault();
            
        }
        public IActionResult OnPost(Contact contact)
        {

            db.tbl_Contact.Add(contact);
            db.SaveChanges();
            return RedirectToPage("Index");

        }
    }
}
