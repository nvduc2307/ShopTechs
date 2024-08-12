using System;
using System.Diagnostics;
using System.Net;
using System.Security.Claims;
using Entities;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorks;
using Utils;
namespace Controllers
{
    public class UserController : ControllerBase {
        private readonly ILogger<UserController> _logger;
        private IUnitOfWork _unitOfWork;
        private IConfiguration _configuration;
        public UserController(ILogger<UserController> logger, IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }
        [HttpGet]
        [Route("/api/users")]
        public async Task<ActionResult> GetUsers() {
            try
            {
                var users = await _unitOfWork.IUserRepository.FetchData();
                return Ok(users);
            }
            catch (System.Exception)
            {
                return Ok(HttpStatusCode.NotFound);
            }
        }
        [HttpPost]
        [Route("/api/login")]
        public async Task<UserEntity> Login(UserLogin userInfoLogin) {
            var token = "";
            try
            {
                var user = await _unitOfWork.IUserRepository.Login(userInfoLogin);
                if (user != null) {
                    var claims = new List<Claim>() {
                        new Claim(ClaimTypes.Name, user.Name),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Upn, user.PassWord)};
                    token = GenerateJWT.CreateJwtToken(claims, _configuration);
                    Console.WriteLine(claims);
                }
                return user;
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}