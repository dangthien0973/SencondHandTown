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
using BC = BCrypt.Net.BCrypt;
using System.Threading.Tasks;
using PagedList;

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

                var user = _context.Users.FirstOrDefault(p => p.UserName == userModel.UserName);
                if (user == null)
                {
                    return Ok(new
                    {
                        Status = false,
                        Message = "Tên đăng nhập hoặc mật khẩu không đúng nè"

                    });
                }  if (!BC.Verify(userModel.Passwords, user.Passwords))
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
        public IActionResult Register(RegisterUser registerUser)
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

            
                    _context.Users.Add(user);
                      _context.SaveChanges();
                    
                
                return Ok("success");       

                
                
            }
            catch (Exception e)
            {
                return Ok(e);
            }
        }
        [HttpPost("getProducList")]
        public IActionResult getProducList(userPage userPage)
        {


            IEnumerable<Product> productslist = _context.Products;
            if (userPage.filedName == "price" && userPage.sortType == "des")
            {

                productslist = productslist.OrderByDescending(s => s.Price);
            }
            else if (userPage.filedName == "price" && userPage.sortType == "asc")
            {

                productslist = productslist.OrderBy(s => s.Price);
            }
            var sort = new
            {
                userPage.filedName,
                userPage.sortType,

            };


            var payload = productslist.ToPagedList(userPage.Page, userPage.PageSize);
            return Ok(new
            {
                userPage.Page,
                userPage.PageSize,
                sort,
                payload
            }
               );
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
