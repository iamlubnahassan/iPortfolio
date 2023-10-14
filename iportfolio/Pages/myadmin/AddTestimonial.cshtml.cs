using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iportfolio.Pages.myadmin
{
    public class AddTestimonialModel : PageModel
    {
        AppDbContext db;
        IWebHostEnvironment env;
        public Testimonial testimonial { get; set; }
        public AddTestimonialModel(AppDbContext _db, IWebHostEnvironment env)
        {
            db = _db;
            this.env = env;

        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Testimonial testimonial) 
        {
            if(ModelState.IsValid)
            {
                string ImageName = testimonial.Photo.FileName.ToString();
                var FolderPath = Path.Combine(env.WebRootPath, "image");
                var ImagePath = Path.Combine(FolderPath, ImageName);
                FileStream fileStream = new(ImagePath, FileMode.Create);
                testimonial.Photo.CopyTo(fileStream);
                fileStream.Dispose();
                testimonial.Image = ImageName;

                db.tbl_testimonial.Add(testimonial);
                db.SaveChanges();
                

            }
            return Page();
            
        }
    }
}
