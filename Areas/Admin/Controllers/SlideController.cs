using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using purplebuzzzzzzzz.DAL;
using purplebuzzzzzzzz.Models;

namespace purplebuzzzzzzzz.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlideController : Controller
    {
        public readonly AppDbContext _context;
        public SlideController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ActionResult> Index()
        {
            List<Slide> slides = await _context.Sliders.ToListAsync();
            return View(slides);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<ActionResult> Create(Slide slide)
        {
            

            if (!ModelState.IsValid)
            {
                return View(slide);
            }

            if (!slide.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Fayl uygun formatda deyil");
                return View(slide);
            }

            if(slide.Photo.Length > 2*1024*1024)
            {
                ModelState.AddModelError("Photo", "Faylin hecmi uygun deyil");
                return View(slide);
            }


            string fileName = String.Concat(Guid.NewGuid().ToString(), slide.Photo.FileName);
            string path = "C:\\Users\\Silent Telecomp\\source\\repos\\purplebuzzzzzzzz\\wwwroot\\assets\\images\\website-images\\" + fileName;
            FileStream fileStream = new(path, FileMode.Create);
            await slide.Photo.CopyToAsync(fileStream);
            fileStream.Close();
            slide.Image = fileName;



            //return Content(slide.Photo.FileName + " " + slide.Photo.ContentType + " " + slide.Photo.Length);
            await _context.Sliders.AddAsync(slide);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
