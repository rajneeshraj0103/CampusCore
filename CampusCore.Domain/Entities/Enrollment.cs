namespace CampusCore.Domain.Entities
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public DateTime EnrollmentDate { get; set; }

        // Navigation Properties

        public Student Student { get; set; } = null!;

        public Course Course { get; set; } = null!;
    }
}
