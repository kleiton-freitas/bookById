using System.Collections.Generic;
using BookByIdApi.Data.ValueObject;

namespace BookByIdApi.Businness
{
    public interface IUserBusinness
    {
        UserVo FindDetailUser(string email);
        List<UserVo> FindAllUsers();
        UserVo FindByID(int id);
    }
}
