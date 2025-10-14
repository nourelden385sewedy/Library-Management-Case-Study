using Library_Management_Case_Study.Data;
using Library_Management_Case_Study.Data.Models;
using Library_Management_Case_Study.Repos.GenericRepository;
using Library_Management_Case_Study.Repos.Interfaces;

namespace Library_Management_Case_Study.Repos
{
    public class UserRepo : GenericRepo<User>, IUserRepo
    {
        public UserRepo(MyAppDbContext context) : base(context)
        {
        }
    }
}
