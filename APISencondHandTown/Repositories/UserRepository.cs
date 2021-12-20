
using APISencondHandTown.Dto;
using APISencondHandTown.Models;

using System.Linq;

namespace APISencondHandTown.Repositories
{
    public interface IUserRepository
    {
        User getByUserName(UserModelDto userModelDto);
        User isCheckByUserName(RegisterUserDto registerUser);
    }
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DB_TMDTContext context) : base(context)
        {

        }
        public override User Get(int id)
        {
            return context.Users.FirstOrDefault();
        }

        public User getByUserName(UserModelDto userModelDto)
        {
            return context.Users.FirstOrDefault(p => p.UserName == userModelDto.UserName);
        }

        public User isCheckByUserName(RegisterUserDto registerUser)
        {
            return context.Users.FirstOrDefault(p => p.UserName == registerUser.UserName);
        }
    }
}
