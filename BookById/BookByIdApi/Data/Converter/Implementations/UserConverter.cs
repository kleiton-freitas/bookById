using System;
using System.Collections.Generic;
using System.Linq;
using BookByIdApi.Data.Converter.Contract;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;

namespace BookByIdApi.Data.Converter.Implementations
{
    public class UserConverter : IParser<UserVo, User>, IParser<User, UserVo>
    {
        public User Parse(UserVo origin)
        {
            if (origin == null) return null;
            return new User
            {
                ID = origin.UserID,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Email = origin.Email,
                Password = origin.Password,
                Document = origin.Document,
                CellPhone = origin.CellPhone,
                SocialNetwork = origin.SocialNetwork,
                Picture = origin.Picture,
                RefreshToken = origin.RefreshToken,
                RefresTokenExpiryTime = origin.RefresTokenExpiryTime
                
            };
        }
        public UserVo Parse(User origin)
        {
            if (origin == null) return null;
            return new UserVo
            {
                UserID = origin.ID,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Email = origin.Email,
                Password = origin.Password,
                Document = origin.Document,
                CellPhone = origin.CellPhone,
                SocialNetwork = origin.SocialNetwork,
                Picture = origin.Picture,
                RefreshToken = origin.RefreshToken,
                RefresTokenExpiryTime = origin.RefresTokenExpiryTime

            };
        }
        public List<User> Parse(List<UserVo> origin)
        {
            if (origin == null) return null;
            return origin.Select(item=> Parse(item)).ToList();
        }

        public List<UserVo> Parse(List<User> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
