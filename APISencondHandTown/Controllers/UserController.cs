using APISencondHandTown.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BC = BCrypt.Net.BCrypt;
using APISencondHandTown.unitOfWork.Repositories;
using APISencondHandTown.Dto;
using APISencondHandTown.unitOfWork;

namespace APISencondHandTown.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IUserRepository _userRepositoryMoreMethod;
        private readonly AppSettings _appSettings;
        public UserController(IUnitOfWork unitOfWork, IOptionsMonitor<AppSettings> optionMonitor, IUserRepository _userRepositoryMoreMethod)
        {
            this.unitOfWork = unitOfWork;              
            _appSettings = optionMonitor.CurrentValue;
           this._userRepositoryMoreMethod= _userRepositoryMoreMethod;
        }

        [HttpGet("getAllUser")]
        public IActionResult Validate()
        {
            return Ok();
        }
        [HttpPost("Login")]
        public IActionResult Validate(UserModelDto UserModelDto)
        {
            try
            {
                var user = _userRepositoryMoreMethod.getByUserName(UserModelDto);
                if (user == null)
                {
                    return Ok(new
                    {
                        Status = false,
                        Message = "Tên đăng nhập hoặc mật khẩu không đúng nè"
                    });
                }                
                if (!BC.Verify(UserModelDto.Passwords, user.Passwords))                
                {
                        return Ok(new
                        {
                            Status = false,
                            Message = "Tên đăng nhập hoặc mật khẩu không đúng nè"
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
        [HttpPost("Register")]
        public IActionResult Register(RegisterUserDto registerUser)
        {
            try
            {
                var user = new User()
                {
                    
                    UserName = registerUser.UserName,
                    Passwords = BC.HashPassword(registerUser.Passwords),
                    /*   Passwords=registerUser.Passwords,*/
                    Address = registerUser.Address,
                    Phone = registerUser.Phone,
                    Email = registerUser.Email,
                    DateCreated = registerUser.Created1,
                    Roles = registerUser.Roles,
                    Statuss = registerUser.Statuss,
                };
                if(_userRepositoryMoreMethod.isCheckByUserName(registerUser) == null)
                {
                    unitOfWork.UserRepository.Add(user);
                    unitOfWork.SaveChanges();                
                }
                else
                {
                    return Ok("The account is already in use ");
                }    
                return Ok("success");            
            }
            catch (Exception e)
            {
                return Ok(e.Message);              
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
