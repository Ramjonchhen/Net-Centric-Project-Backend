using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using Net_Centric_Project.Models;
using Net_Centric_Project.DTOs;

namespace Net_Centric_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private static Admin admin = new Admin();

        [HttpPost("register")]
        public async Task<ActionResult<Admin>> Register(AdminRegister request)
        {
            CreatePassowordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);
            admin.Name = request.Name; 
            admin.Email = request.Email;
            admin.Hash = passwordHash;
            admin.Salt = passwordSalt;
            return Ok(admin);
        }

        public async Task<ActionResult> Login(UserLogin userLogin)
        {

        }

        private void CreatePassowordHash(string password,out byte[] passwordHash, out byte[] passwordSalt) 
        {
            using ( var hmac  = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
