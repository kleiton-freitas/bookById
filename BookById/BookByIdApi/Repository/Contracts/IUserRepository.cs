using System;
using BookByIdApi.Model;
namespace BookByIdApi.Repository.Contracts
{
    public interface IUserRepository
    {
        User ValidateCredentials(User user);
        User ValidateCredentials(string email);
        User RefreshUserInfo(User user);
        bool RevokeToken(string email);

    }
}
