using ExceptionHandling.Models;

namespace ExceptionHandling.Services;

public interface IUserService
{
    List<UserModel> GetUsers();

    UserModel GetUser(int id);
}