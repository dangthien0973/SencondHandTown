using APISencondHandTown.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace APISencondHandTown.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DB_TMDTContext _context;
        private readonly AppSettings _appSettings;
        public UserController(DB_TMDTContext context,IOptionsMonitor<AppSettings> optionMonitor)
        {
            _context = context;
            _appSettings = optionMonitor.CurrentValue;
        }

        [HttpGet("getAllUser")]
        public IActionResult Validate()
        {
            return Ok();
        }
        [HttpPost("Login")]
        public IActionResult Validate(UserModel userModel)
        {
            try
            {

                var user = _context.Users.SingleOrDefault(p => p.UserName == userModel.UserName && p.Passwords == userModel.Passwords);
                if (user == null)
                {
                    return Ok(new {
                        Status = false,
                        Message="Tên đăng nhập hoặc mật khẩu không đúng nè"

                    });
                }
                else
                {
                    /*return Ok(user);*/
                    // cấp token 
                    return Ok(new
                    {
                        Status = true,
                        Message = "Cấp Token nè ae",
                        Data = GenerateToken(user)

                    });
                }
            }
            catch(Exception e)
            {
                return Ok(e);
            }
        }
        private string GenerateToken(User user)
        {
            var jwtToken = new JwtSecurityTokenHandler();
            var secretByte = Encoding.UTF8.GetBytes(_appSettings.SecretKey);
            var tokenDescription = new SecurityTokenDescriptor
            {
                // ham de truyen cho ae
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim("Id", user.UserId.ToString()),

                    new Claim("tokenID", Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddSeconds(30),
                SigningCredentials=new SigningCredentials(new SymmetricSecurityKey(secretByte),SecurityAlgorithms.HmacSha512Signature)
            };
            var token = jwtToken.CreateToken(tokenDescription);
            return jwtToken.WriteToken(token);
        }
    }
}
