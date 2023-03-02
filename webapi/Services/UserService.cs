using webapi.Models;
using MongoDB.Driver;

namespace webapi.Services
{
    public class UserService : IUserServices
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IUserStoreDatabaseSettings settings,IMongoClient mongoClient)
        {
            var database =mongoClient.GetDatabase(settings.DatabaseName);
            _users=database.GetCollection<User>(settings.UserCollectionName);
        }
        public User CreateUser(User user)
        {
             _users.InsertOne(user);
            return user;


        }

        public User GetUser(string id)
        {
           return _users.Find(user => user.Id == id).FirstOrDefault(); 
        }

        public List<User> GetUsers()
        {
           return _users.Find(user => true).ToList();
        }

        public void UserUpdate(string id,User user)
        {
            _users.ReplaceOne(user => user.Id == id, user);
            
        }
    }
}
