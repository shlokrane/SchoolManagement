using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public enum UserType
    {
        Teacher = 0,
        Student = 1
    }
    public class User
    {
        // This is the primary key for the unified user table.
        [Key]
        public int UserID { get; set; }

        // Discriminator to know if this user is a student or teacher.
        public UserType UserType { get; set; }

        public string Name { get; set; }
        public string EmailID { get; set; }
        public string PhoneNo { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string PasswordHash { get; set; }
    }
}
