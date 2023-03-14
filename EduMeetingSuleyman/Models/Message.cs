using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduMeetingSuleyman.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar(50)"),Display(Name = "Adı"),StringLength(50)]
        public string NameSurname { get; set; }

        [Column(TypeName = "Varchar(50)"), Display(Name = "mailin"), StringLength(50)]
        public string MailAddress { get; set; }

        [Column(TypeName = "Varchar(50)"), Display(Name = "konu"), StringLength(50)]
        public string Subject { get; set; }

        [Column(TypeName = "Varchar(500)"), Display(Name = "mesaj"), StringLength(500)]
        public string Messages { get; set; }

        [ Display(Name = "Eğitim Adı")]
        public DateTime RecDate { get; set; }

        [Column(TypeName = "Varchar(50)"), Display(Name = "ipnosu")]
        public string IPNO { get; set; }
    }
}
