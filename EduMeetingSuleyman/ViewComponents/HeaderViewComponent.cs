using Microsoft.AspNetCore.Mvc;

namespace EduMeetingSuleyman.ViewComponents
{
    public class HeaderViewComponent: ViewComponent  //ViewComponent .net core dan geliyor.
    {
        public IViewComponentResult Invoke() //bu özel ad invoke çünkü tek bi view gönderiyo başka zaten gönderemez
        {
            return View();
        }
    }
}
