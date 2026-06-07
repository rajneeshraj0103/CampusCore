namespace CampusCore.Domain.Entities
{
    public class Role
    {
        public int RoleId {  get; set; }

        public string RoleName { get; set; } = string.Empty;

        public DateTime CreatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int? DeletedBy { get; set; }

        // Navigation Property

        public ICollection<User> Users { get; set; }
            = new List<User>();
    }
}
