using Microsoft.AspNetCore.Identity;
using Swachify.Infrastructure.Models;
using Swachify.Infrastructure.Data;
namespace Swachify.Application;

public class AuthService(MyDbContext _dbContext)
{
    // private readonly PasswordHasher<user_auth> _passwordHasher = new PasswordHasher<user_auth>();

    // public user_auth CreateUser(long userId, string loginName, string plainPassword)
    // {
    //     var userAuth = new user_auth
    //     {
    //         user_id = userId,
    //         login_name = loginName,
    //         is_active = true,
    //         created_date = DateTime.UtcNow
    //     };

    //     // Hash the password
    //     userAuth.password = _passwordHasher.HashPassword(userAuth, plainPassword);

    //     _dbContext.user_auths.Add(userAuth);
    //     _dbContext.SaveChanges();

    //     return userAuth;
    // }

    //public async Task<user_auth?> ValidateCredentialsAsync(string email, string password, CancellationToken ct = default)
    //{
    //    var user_auth = await db.user_auth.FirstOrDefaultAsync(u => u.login_name == email, ct);
    //    if (user_auth is null) return null;
    //    return hasher.Verify(password, user_auth.password) ? user_auth : null;
    //}
}
