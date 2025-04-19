using System.ComponentModel.DataAnnotations;

namespace SchoolAppCore.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
