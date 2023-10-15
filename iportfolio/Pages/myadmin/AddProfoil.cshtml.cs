using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class AddProfoilModel : PageModel
    {
        AppDbContext db;
        IWebHostEnvironment env;
        public Profoil profoil { get; set; }
        public AddProfoilModel(AppDbContext _db, IWebHostEnvironment env)
        {
            db = _db;
            this.env = env;

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
        public IActionResult OnPost(Profoil profoil)
        { 
            if(ModelState.IsValid)
            {
                string ImageName = profoil.Photo.FileName.ToString();
                var FolderPath = Path.Combine(env.WebRootPath, "image");
                var ImagePath = Path.Combine(FolderPath, ImageName);
                FileStream fs = new FileStream(ImagePath, FileMode.Create);
                profoil.Photo.CopyTo(fs);
                fs.Dispose();
                profoil.Image = ImageName;
                db.tbl_Profoil.Add(profoil);
                db.SaveChanges();

            }
            return Page();
            

        }
    }
}
