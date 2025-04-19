using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolAppCore.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public decimal? Grade { get; set; }
        public required virtual Course Course { get; set; }
        public required virtual Student Student { get; set; }
    }
}
