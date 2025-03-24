using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public enum AttendanceStatus
    {
        Absent = 0,
        Present = 1,
        Leave = 2
    }
    public class Attendance
    {
        public int AttendanceID { get; set; }      // Primary Key
        public int StudentID { get; set; }         // FK to User Table
                                                   //public int TeacherId { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }         // Attendance Date
        public AttendanceStatus Status { get; set; } // Present / Absent

        public User Student { get; set; }
    }
}
