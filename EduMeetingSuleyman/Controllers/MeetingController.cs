using EduMeetingSuleyman.Models;
using EduMeetingSuleyman.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduMeetingSuleyman.Controllers
{
    public class MeetingController : Controller
    {


        DataContext db;
        public MeetingController(DataContext _db)
        {
            db = _db;
        }


        //[Route("[controller]/deneme/[action]")] şu şekilde olur= meeting/deneme/index
        [Route("/toplantilar")] //bu şekilde yazarak ad değişti. seo da oldu ve bu kadar basit ad değiştimek. tag helper kull. direk tanıyor bunu ayrıca
        public IActionResult Index()
        {
            MeetingVM meetingVM = new MeetingVM
            {
                Categories = db.Category.OrderBy(x => x.DisplayIndex),
                Meetings = db.Meeting.OrderBy(x => x.DisplayIndex)
            };
            return View(meetingVM);
        }


        [Route("/toplanti/detay/{name}/{id}")] //eğer süslülerde birşey varsa aşağiya değeriyle beraber yazılır. string name gibi 
        public IActionResult Detail(string name, int id)
        {
            return View(db.Meeting.First(x=> x.Id==id));   //bu LINQ sorgusudur. (ilki getir) x burada her bir kaydı demek oluyor. lamda solundaki x her bir i demek. ama normal büyük db lerde IQUarable kullanılıyor ve onu kullanıcağız.
        }

    }

}



//IQuarable : normal yukardaki linq sorguları ram i yoruyor o yüzden gerçek db lerde IQuarable kullanılıyor.
