namespace CampusCore.Domain.Entities
{
    public class Result
    {
        public int ResultId { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public decimal MarksObtained { get; set; }

        public decimal MaximumMarks { get; set; }

        public string ResultStatus { get; set; } = string.Empty;

        public DateTime ExamDate { get; set; }

        public DateTime PublishedDate { get; set; }

        public int PublishedBy { get; set; }

        // Navigation Properties

        public Student Student { get; set; } = null!;

        public Course Course { get; set; } = null!;
    }
}
