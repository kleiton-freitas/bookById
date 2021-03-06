﻿using System;
using System.Collections.Generic;
using BookByIdApi.Model;
namespace BookByIdApi.Repository.Contracts
{
    public interface IUserRepository
    {
        User ValidateCredentials(User user);
        User ValidateCredentials(string email);
        User RefreshUserInfo(User user);
        bool RevokeToken(string email);

        User FindDetailUsers(string email);
        List<User> FindAllUsers();

        User UpdateUser(User user);

    }
}
