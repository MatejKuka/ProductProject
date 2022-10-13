using Application.Interfaces;

namespace Application.UserAuthentication;

public class UserAuthenticator : IUserAuthenticator
{
    private readonly IUserRepository _userRepository;
    private readonly IAuthenticationHelper _authenticationHelper;
    
    public UserAuthenticator(IUserRepository userRepository, IAuthenticationHelper authenticationHelper)
    {
        _userRepository = userRepository;
        _authenticationHelper = authenticationHelper;
    }
    
    public bool Login(string username, string password, out string token)
    {
        token = "need to implement this function";
        return true;
        //Todo Finish Login
    }

    public bool CreateUser(string username, string password)
    {
        return true;
        //Todo Finish CreateUser
    }
}