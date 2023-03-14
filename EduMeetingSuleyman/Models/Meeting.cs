using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EduMeetingSuleyman.Models
{
    
    public class Meeting
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar(50)"),
         Required(ErrorMessage = "bişeyler yaz boş geçemezssin"),
         Display(Name = "Meeting Adı"),
         StringLength(10, ErrorMessage = "En fazla 50 girebilirsin")]// Bunlar annotationlar. üstede ekledi zaten bunu yazınca. varmax yaptı defaultta. değitiriyoz.
        public string Name { get; set; }

        [Column(TypeName = "Varchar(100)")]
        public string Decription { get; set; }

        [Column(TypeName = "Varchar(150)")]
        public string Picture { get; set; }


        public string DisplayIndex { get; set; }

        [Column(TypeName = "Decimal(18,2)")]
        public decimal Price { get; set; }

        public DateTime RecDate { get; set; }

        public int? CategoryId { get; set; }    //yandaki soru işaretiyle null yaptık set null
        public Category Category { get; set; }

        [Column(TypeName ="Text")]
        public string Detail { get; set; }
    }
}