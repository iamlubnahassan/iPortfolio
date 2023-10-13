using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class UpdateContactModel : PageModel
    {
        AppDbContext db;
        public Contact contact { get; set; }
        public UpdateContactModel(AppDbContext _db)
        {
            db= _db;
        }
        public void OnGet(int Id)
        {
            contact = db.tbl_Contact.Find(Id);
        }
        public IActionResult OnPost(Contact contact)
        { 
            db.tbl_Contact.Update(contact);
            db.SaveChanges();
            return RedirectToPage("ShowContact");
        }
    }
}
