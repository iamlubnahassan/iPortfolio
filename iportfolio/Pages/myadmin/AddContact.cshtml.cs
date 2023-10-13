using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{

    public class AddContactModel : PageModel
    {
        AppDbContext db;
        public Contact contact { get; set; }
        public AddContactModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost(Contact contact)
        {
            db.tbl_Contact.Add(contact);
            db.SaveChanges();
            return RedirectToPage("ShowContact");

        }
    }
}
