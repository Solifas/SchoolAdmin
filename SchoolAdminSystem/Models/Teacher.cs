using System;

namespace SchoolAdminSystem.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }

    }
}
