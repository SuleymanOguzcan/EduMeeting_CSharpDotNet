using EduMeetingSuleyman.Models;

namespace EduMeetingSuleyman.ViewModels
{
    public class IndexVM
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Meeting> Meetings { get; set; }
        public IEnumerable<Education> Educations { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public Message Message { get; set; }  //liste döndürmeyeceğimiz için sadece mesaj yeterli
    }
}
