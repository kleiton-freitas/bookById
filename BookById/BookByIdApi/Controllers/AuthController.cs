using System;
using BookByIdApi.Businness;
using BookByIdApi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace BookByIdApi.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private ILoginBusinness _loginBusinness;

        public AuthController(ILoginBusinness loginBusinness)
        {
            _loginBusinness = loginBusinness;
        }
        [HttpPost]
        [Route("signin")]
        public IActionResult Signin([FromBody] User user)
        {
            if (user == null) return BadRequest("Requisição Ivalida");
            var token = _loginBusinness.ValidateCredentials(user);
            if (token == null) return Unauthorized();
            return Ok(token);
        }
        [HttpPost]
        [Route("refresh")]
        public IActionResult Refresh([FromBody] Token token)
        {
            if (token == null) return BadRequest("Requisição Invalida");
            var _token = _loginBusinness.ValidateCredentials(token);
            if (_token is null) return BadRequest("Requisição Inválida");
            return Ok(_token);
        }
        [HttpGet]
        [Route("revoke")]
        [Authorize("Bearer")]
        public IActionResult Revoke()
        {
            var userLogin = User.Identity.Name;
            var result = _loginBusinness.RevokeToken(userLogin);
            if (!result) return BadRequest("Requisição de Client Invalida");
            return NoContent();
        }
        
    }
}
