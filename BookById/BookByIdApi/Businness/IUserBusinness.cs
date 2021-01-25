using System.Collections.Generic;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;

namespace BookByIdApi.Businness
{
    public interface IUserBusinness
    {
        UserVo FindDetailUser(string email);
        List<UserVo> FindAllUsers();
        UserVo FindByID(int id);
        UserVo Create(UserVo user);
        UserVo UpdateUser(UserVo user);
        void Delete(int id);
        UserVo Update(UserVo user);
    }
}
