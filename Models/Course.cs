namespace SchoolAppCore.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public required string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
        public required virtual Department Department { get; set; }

    }
}