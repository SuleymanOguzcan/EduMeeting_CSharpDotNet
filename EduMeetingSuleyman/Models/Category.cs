namespace EduMeetingSuleyman.Models
{
        public class Category
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string DisplayIndex { get; set; }

            public ICollection<Meeting> Meetings { get; set; } // bire çok ilişki kuruldu koleksiyonumuz var gibi mmeting de (category e de yazdık)
        }
}
