using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class UpdateTestimonialModel : PageModel
    {
        AppDbContext db;
        IWebHostEnvironment env;
        public Testimonial testimonial { get; set; }
        public UpdateTestimonialModel(AppDbContext _db,IWebHostEnvironment env)
        {
            db = _db;
            this.env = env;
        }
        public IActionResult OnGet(int Id)
        {
            testimonial = db.tbl_testimonial.Find(Id);
            var Verify = HttpContext.Session.GetString("flag");
            if (Verify == null)
            {
                return RedirectToPage("../myadmin/Login");
            }
            return Page();
        }
        public IActionResult OnPost(Testimonial testimonial)
        { 
            if(testimonial.Photo is null)
            {
                db.tbl_testimonial.Update(testimonial);
                db.SaveChanges();

            }
            else
            {
                string ImageName = testimonial.Photo.FileName.ToString();
                DeleteFile(testimonial.Image);
                var FolderPath = Path.Combine(env.WebRootPath, "image");
                var ImagePath = Path.Combine(FolderPath, ImageName);
                var myFileStream = new FileStream(ImagePath, FileMode.Create);
                testimonial.Photo.CopyTo(myFileStream);
                myFileStream.Dispose();
                testimonial.Image = ImageName;
                db.tbl_testimonial.Update(testimonial);
                db.SaveChanges();

            }

            return RedirectToPage("UpdateTestimonial");
        }
        public void DeleteFile(string OldImageName)
        {
            var FolderPath = Path.Combine(env.WebRootPath, "image");
            var ImagePath= Path.Combine(FolderPath, OldImageName);

            FileInfo fileInFo = new FileInfo(ImagePath);
            if (fileInFo.Exists)
            {
                fileInFo.Delete();
            }
        }
    }
}
