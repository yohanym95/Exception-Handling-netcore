using ExceptionHandling.Models;

namespace ExceptionHandling.Services;

public class UserService : IUserService
{
    /*private List<UserModel> _users = new List<UserModel>()
    {
        new UserModel() {Id = 1, Email = "Jhon@gmail.com", Name = "Jhon Silva"},
        new UserModel() {Id = 2, Email = "Kumar@gmail.com", Name = "Kumar Fernando"},
        new UserModel() {Id = 3, Email = "Bredy@gmail.com", Name = "Bredy Silva"}
    };*/

    private List<UserModel> _users = new List<UserModel>();
    
    public List<UserModel> GetUsers()
    {
        return _users;
    }

    public UserModel GetUser(int id)
    {
        _users.Clear();
        return _users.Where(u => u.Id == id).FirstOrDefault();
    }
}