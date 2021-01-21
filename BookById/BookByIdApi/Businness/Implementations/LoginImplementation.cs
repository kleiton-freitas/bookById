using System;
using BookByIdApi.Model;
using BookByIdApi.Configurations;
using BookByIdApi.Repository.Contracts;
using BookByIdApi.Services;
using System.Collections.Generic;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace BookByIdApi.Businness.Implementations
{
    public class LoginImplementation : ILoginBusinness
    {
        private const string DATE_FORMAT = "yyyy-MM-dd HH:mm:ss";
        private TokenConfigurations _configuration;
        private IUserRepository _repository;
        private readonly IToken _token;

        public LoginImplementation(TokenConfigurations configuration, IUserRepository repository, IToken token)
        {
            _configuration = configuration;
            _repository = repository;
            _token = token;
        }

        public Token ValidateCredentials(User userCredential)
        {
            var user = _repository.ValidateCredentials(userCredential);
            if (user == null)
            {
                return null;
            }
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.Email)
            };
            var accesstoken = _token.GenerateAccessToken(claims);
            var refreshtoken = _token.GenerateRefreshToken();

            user.RefreshToken = refreshtoken;
            user.RefresTokenExpiryTime = DateTime.Now.AddDays(_configuration.DaysToExpire);

            _repository.RefreshUserInfo(user);

            DateTime createdDate = DateTime.Now;
            DateTime expirationDate = createdDate.AddMinutes(_configuration.Minutes);

            return new Token
                (
                    true,
                    createdDate.ToString(DATE_FORMAT),
                    expirationDate.ToString(DATE_FORMAT),
                    accesstoken,
                    refreshtoken
                );
        }
        public Token ValidateCredentials(Token token)
        {
            var accessToken = token.AccessToken;
            var refreshToken = token.RefreshToken;

            var principal = _token.GetPrincipalFromExpiredToken(accessToken);
            var userLogin = principal.Identity.Name;
            var user = _repository.ValidateCredentials(userLogin);

            if (user == null || user.RefreshToken != refreshToken || user.RefresTokenExpiryTime <= DateTime.Now) return null;

            accessToken = _token.GenerateAccessToken(principal.Claims);
            refreshToken = _token.GenerateRefreshToken();

            _repository.RefreshUserInfo(user);

            DateTime createdDate = DateTime.Now;
            DateTime expirationDate = createdDate.AddMinutes(_configuration.Minutes);

            return new Token
                (
                    true,
                    createdDate.ToString(DATE_FORMAT),
                    expirationDate.ToString(DATE_FORMAT),
                    accessToken,
                    refreshToken
                );
        }
        public bool RevokeToken(string email)
        {
            return _repository.RevokeToken(email);
        }
    }
}
