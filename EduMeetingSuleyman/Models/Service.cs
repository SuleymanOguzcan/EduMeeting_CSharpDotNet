namespace EduMeetingSuleyman.Models
{
    
        public class Service
        {
            public int Id { get; set; }// id Id ID dersen Sql bunu PK, Identity(1,1) yapar. özel isimlendirme..

            public string Name { get; set; }

            public string Decription { get; set; }

            public string Icon { get; set; }

            public string DisplayIndex { get; set; }
        }
    
}
