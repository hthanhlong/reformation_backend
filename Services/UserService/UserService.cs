using Nike_clone_Backend.Classes;
using Nike_clone_Backend.Models;
using Nike_clone_Backend.UnitOfWork;
namespace Nike_clone_Backend.Services.UserService
{
    public class UserService : GenericService, IUserService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task AddUser(ISignUp user)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel?> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserModel>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}

