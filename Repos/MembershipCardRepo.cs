using Library_Management_Case_Study.Data;
using Library_Management_Case_Study.Data.Models;
using Library_Management_Case_Study.Repos.GenericRepository;
using Library_Management_Case_Study.Repos.Interfaces;

namespace Library_Management_Case_Study.Repos
{
    public class MembershipCardRepo : GenericRepo<MembershipCard>, IMembershipCardRepo
    {
        public MembershipCardRepo(MyAppDbContext context) : base(context)
        {
        }
    }
}
