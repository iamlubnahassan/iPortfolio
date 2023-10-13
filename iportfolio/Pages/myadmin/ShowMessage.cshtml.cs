using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class ShowMessageModel : PageModel
    {
        AppDbContext db;
        public List<Contact> contact { get; set; }
        public ShowMessageModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            contact=db.tbl_Contact.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var ItemToDel = db.tbl_Contact.Find(Id);
            db.tbl_Contact.Remove(ItemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowMessage");
        }
    }
}
