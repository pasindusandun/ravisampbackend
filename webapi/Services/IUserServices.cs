using webapi.Models;
namespace webapi.Services
{
    public interface IUserServices
    {
        List<User> GetUsers();
        User GetUser(string id);

        void UserUpdate(string id, User user);

        User CreateUser(User user);

    }
}
