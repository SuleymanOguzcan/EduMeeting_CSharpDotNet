using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EduMeetingSuleyman.Models
{
    public class Education
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar(50)"), Required(ErrorMessage = "bişeyler yaz boş geçemezssin"), Display(Name = "Eğitim Adı"), StringLength(10, ErrorMessage = "En fazla 50 girebilirsin")]// Bunlar annotationlar. üstede ekledi zaten bunu yazınca. varmax yaptı defaultta. değitiriyoz.
        public string Name { get; set; }

        [Column(TypeName = "Varchar(150)")]
        public string Picture { get; set; }

        public string DisplayIndex { get; set; }

        [Column(TypeName = "Decimal(18,2)")]
        public decimal Price { get; set; }

        public int Star { get; set; }



    }
}



