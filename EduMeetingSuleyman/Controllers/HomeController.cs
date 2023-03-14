
using EduMeetingSuleyman.Models;
using EduMeetingSuleyman.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EduMeetingSuleyman.Controllers
{
    public class HomeController : Controller
    {
        DataContext db;//DI
        public HomeController(DataContext _db)
        {
            db = _db;
        }


        [HttpGet]   //default bu aslında koymasanda olur 
        public IActionResult Index()
        {
            IndexVM indexVM = new IndexVM { 
                Categories = db.Category.OrderBy(x => x.DisplayIndex),
                Meetings = db.Meeting.Include(x => x.Category).OrderBy(x => x.DisplayIndex),   //buradaki include htmlde foreach de başka category cağırırken kızardı diye
                Educations = db.Education.OrderBy(x => x.DisplayIndex),
                Services = db.Service.OrderBy(x => x.DisplayIndex),
                
            };
            return View(indexVM);
        }

        [HttpPost] // biz sana veri yolluycaz 
        public IActionResult Message()   //bu message ismini biz uydurduk mesaj yollanıcak yer diye ole isim vedil
        {
            return View();  
        }


    }
}






