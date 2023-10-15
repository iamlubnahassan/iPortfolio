using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class ShowContactModel : PageModel
    {
        AppDbContext db;
        public List<Contact> contact { get; set; }
        public ShowContactModel(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult OnGet()
        {
            contact = db.tbl_Contact.ToList();
            var Verify = HttpContext.Session.GetString("flag");
            if (Verify == null)
            {
                return RedirectToPage("../myadmin/Login");
            }
            return Page();
        }
        public IActionResult OnGetDelete(int Id)
        { 
            var ItemToDel =db.tbl_Contact.Find(Id);
            db.tbl_Contact.Remove(ItemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowContact");
        }
    }
}
