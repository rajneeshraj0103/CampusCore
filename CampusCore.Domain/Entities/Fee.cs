namespace CampusCore.Domain.Entities
{
    public class Fee
    {
        public int FeeId { get; set; }

        public int StudentId { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal PaidAmount { get; set; }

        public decimal PendingAmount { get; set; }

        public string PaymentStatus { get; set; } = string.Empty;

        public DateTime DueDate { get; set; }

        public DateTime? LastPaymentDate { get; set; }

        // Navigation Property

        public Student Student { get; set; } = null!;
    }
}
