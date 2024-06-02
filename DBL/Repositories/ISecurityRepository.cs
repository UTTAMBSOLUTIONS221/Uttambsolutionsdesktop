using DBL.Models;

namespace DBL.Repositories
{
    public interface ISecurityRepository
    {
        UsermodelResponce VerifySystemStaff(string Username);
    }
}
