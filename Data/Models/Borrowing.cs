using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Management_Case_Study.Data.Models
{
    //[Table("Borrowing")]
    public class Borrowing
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime BorrowDate { get; set; }

        public DateTime? ReturnDate {  get; set; }

        public string Status { get; set; } = "Borrowed";


        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int BookId { get; set; }
        public Book Book { get; set; } = null!;


    }
}
