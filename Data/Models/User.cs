using System.ComponentModel.DataAnnotations;

namespace Library_Management_Case_Study.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Phone]
        public string Phone { get; set; } = null!;


        public List<Borrowing> Borrowings { get; set; } = new List<Borrowing>();

        public MembershipCard? MembershipCard { get; set; }
    }
}
