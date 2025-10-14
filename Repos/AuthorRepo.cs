using Library_Management_Case_Study.Data;
using Library_Management_Case_Study.Data.Models;
using Library_Management_Case_Study.Repos.GenericRepository;
using Library_Management_Case_Study.Repos.Interfaces;

namespace Library_Management_Case_Study.Repos
{
    public class AuthorRepo : GenericRepo<Author>, IAuthorRepo
    {
        public AuthorRepo(MyAppDbContext context) : base(context){ }
    }
}
