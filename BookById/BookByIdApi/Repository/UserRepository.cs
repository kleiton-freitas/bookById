﻿using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using BookByIdApi.Model;
using BookByIdApi.Model.Context;
using BookByIdApi.Repository.Contracts;
namespace BookByIdApi.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MySqlContext _context;

        public UserRepository(MySqlContext context)
        {
            _context = context;
        }

        public User ValidateCredentials(User user)
        {
            var pass = ComputeHash(user.Password, new SHA256CryptoServiceProvider());

            return _context.Users.FirstOrDefault(u => u.Email == user.Email && (u.Password == pass));
        }

        public User ValidateCredentials(string email)
        {
            return _context.Users.SingleOrDefault(u => u.Email == email);
        }
        public bool RevokeToken(string email)
        {
            var user = _context.Users.SingleOrDefault(u => u.Email == email);
            if (user == null) return false;
            user.RefreshToken = null;
            _context.SaveChanges();
            return true;
        }

        public User RefreshUserInfo(User user)
        {
            if (!_context.Users.Any(u => u.UserID.Equals(user.UserID))) return null;

            var result = _context.Users.SingleOrDefault(p => p.UserID.Equals(user.UserID));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
                return result;
            }
            return result;
        }

        private object ComputeHash(string password, SHA256CryptoServiceProvider sHA256CryptoServiceProvider)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(password);
            Byte[] hashedBytes = sHA256CryptoServiceProvider.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
        }
    }
}