using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
  
    public class ShowTestimonialModel : PageModel
    {
        AppDbContext db;
        public List<Testimonial> testimonial { get; set; }
        public ShowTestimonialModel( AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult OnGet()
        {
            testimonial = db.tbl_testimonial.ToList();
            var Verify = HttpContext.Session.GetString("flag");
            if (Verify == null)
            {
                return RedirectToPage("../myadmin/Login");
            }
            return Page();
        }
        public IActionResult OnGetDelete(int Id) 
        {
            var ItemToDel = db.tbl_testimonial.Find(Id);
            db.tbl_testimonial.Remove(ItemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowTestimonial");

        }
    }
}
