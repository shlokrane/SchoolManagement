using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Marks
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MarkID { get; set; }

        [Required]
        public int StudentID { get; set; } // References UserID where UserType = 0

        [Required]
        public int TeacherID { get; set; } // References UserID where UserType = 1

        [Required]
        [MaxLength(50)]
        public string Class { get; set; }

        [Required]
        [MaxLength(10)]
        public string Section { get; set; }

        [Required]
        [MaxLength(100)]
        public string Subject { get; set; }

        [Required]
        public int MarksValue { get; set; }

        [Required]
        [MaxLength(50)]
        public string ExamType { get; set; } // e.g., "Mid Term", "End Term"

        // Foreign Key Relationships
        [ForeignKey("StudentID")]
        public User Student { get; set; }

        [ForeignKey("TeacherID")]
        public User Teacher { get; set; }
    }
}
