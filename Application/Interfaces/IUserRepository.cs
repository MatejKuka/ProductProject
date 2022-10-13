using Domain;

namespace Application.Interfaces;

public interface IUserRepository
{
    public IEnumerable<User> GetAllUsers();

    public User GetUser(long id);

    public void AddUser(User entity);

    public void EditUser(User entity);

    public void RemoveUser(long id);

}