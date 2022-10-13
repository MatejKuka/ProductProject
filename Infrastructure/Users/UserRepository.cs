using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class UserRepository : IUserRepository
{
    private readonly SecurityContext _context;

    public UserRepository(SecurityContext context)
    {
        _context = context;
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _context.Users.ToList();
    }

    public User GetUser(long id)
    {
        return _context.Users.FirstOrDefault(b => b.Id == id);
    }

    public void AddUser(User entity)
    {
        _context.Users.Add(entity);
        _context.SaveChanges();
    }

    public void EditUser(User entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void RemoveUser(long id)
    {
        var item = GetUser(id);
        _context.Users.Remove(item);
        _context.SaveChanges();
    }
}