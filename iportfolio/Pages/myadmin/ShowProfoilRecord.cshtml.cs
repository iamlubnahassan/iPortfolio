using iportfolio.Data;
using iportfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace iportfolio.Pages.myadmin
{
    public class ShowProfoilRecordModel : PageModel
    {
        AppDbContext db;
        IWebHostEnvironment env;
        public Profoil profoil { get; set; }
        public ShowProfoilRecordModel(AppDbContext _db, IWebHostEnvironment env)
        {
            db = _db;
            this.env = env;

        }
        public void OnGet()
        {
            profoil = db.tbl_Profoil.FirstOrDefault();
        }

        public IActionResult OnPost(Profoil profoil)
        { 
            if(profoil.Photo is null) 
            { 
                db.tbl_Profoil.Update(profoil);
                db.SaveChanges();
            }
            else 
            {
                string ImageName = profoil.Photo.FileName.ToString();
                DeleteFile(profoil.Image);
                var FolderPath = Path.Combine(env.WebRootPath, "image");
                var ImagePath = Path.Combine(FolderPath, ImageName);
                var myFileStream = new FileStream(ImagePath, FileMode.Create);
                profoil.Photo.CopyTo(myFileStream);
                myFileStream.Dispose();
                profoil.Image = ImageName;
                db.tbl_Profoil.Update(profoil);
                db.SaveChanges();
                
            }
            return RedirectToPage("ShowProfoilRecord");

        }
        public void DeleteFile(string OldImageName)
        {
            var FolderPath = Path.Combine(env.WebRootPath , "image");
            var ImagePath = Path.Combine(FolderPath, OldImageName);

            FileInfo fileInFo= new FileInfo(ImagePath);
            if (fileInFo.Exists)
            {
                fileInFo.Delete();
            }
        }
    }
}
