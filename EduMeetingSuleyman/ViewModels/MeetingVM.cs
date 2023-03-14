using EduMeetingSuleyman.Models;

namespace EduMeetingSuleyman.ViewModels
{
    public class MeetingVM
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Meeting> Meetings { get; set; }
    }
}
