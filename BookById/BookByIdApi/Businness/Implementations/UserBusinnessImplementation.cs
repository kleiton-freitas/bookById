using System;
using System.Collections.Generic;
using BookByIdApi.Data.Converter.Implementations;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
using BookByIdApi.Repository.Contracts;
using BookByIdApi.Repository.Generic;

namespace BookByIdApi.Businness.Implementations
{
    public class UserBusinnessImplementation : IUserBusinness
    {

        private readonly IUserRepository _userRepository;
        private readonly IRepository<User> _repository;
        private readonly UserConverter _userConverter;

        public UserBusinnessImplementation(IUserRepository userRepository, IRepository<User> repository)
        {
            _userRepository = userRepository;
            _repository = repository;
            _userConverter = new UserConverter();
        }
        //public UserVo Create(UserVo user)
        //{
        //    var userEntity = _userConverter.Parse(user);
        //    userEntity = _repository.Create(userEntity);
        //    return _userConverter.Parse(userEntity);
        //}

        public List<UserVo> FindAllUsers()
        {
            return _userConverter.Parse(_userRepository.FindAllUsers());
        }

        public UserVo FindDetailUser(string email)
        {
            return _userConverter.Parse(_userRepository.FindDetailUsers(email));
        }
        public UserVo FindByID(int id)
        {
            return _userConverter.Parse(_repository.FindById(id));
        }
    }
}
