using System;
using BookByIdApi.Model;
namespace BookByIdApi.Businness
{
    public interface ILoginBusinness
    {
        Token ValidateCredentials(User user);
        Token ValidateCredentials(Token token);
        bool RevokeToken(string email);
    }
}
