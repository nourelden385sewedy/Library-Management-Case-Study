using Library_Management_Case_Study.Data;
using Library_Management_Case_Study.Data.Models;
using Library_Management_Case_Study.Repos.GenericRepository;
using Library_Management_Case_Study.Repos.Interfaces;

namespace Library_Management_Case_Study.Repos
{
    public class BorrowingRepo : GenericRepo<Borrowing>, IBorrowingRepo
    {
        public BorrowingRepo(MyAppDbContext context) : base(context) { }
    }
}
