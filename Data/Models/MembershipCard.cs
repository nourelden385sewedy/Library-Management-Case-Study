using System.ComponentModel.DataAnnotations;

namespace Library_Management_Case_Study.Data.Models
{
    public class MembershipCard
    {
        public int Id { get; set; }

        [Required]
        public string CardNo { get; set; } = null!;

        [Required]
        public DateTime IssueDate { get; set; }

        [Required]
        public DateTime ExpireDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
