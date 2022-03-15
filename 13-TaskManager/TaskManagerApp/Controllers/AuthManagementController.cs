using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using TaskManagerApp.configuration;
using TaskManagerApp.Models.DTOs.Requests;
using TaskManagerApp.Models.DTOs.Responses;

namespace TaskManagerApp.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthManagementController : ControllerBase
    {
        
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtConfig _jwtconfig;
        public AuthManagementController(
            UserManager<IdentityUser> userManager,
            IOptionsMonitor<JwtConfig> optionsMonitor
            )
        {
            _userManager = userManager;
            _jwtconfig = optionsMonitor.CurrentValue;            
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationDto user)
        {
            if(ModelState.IsValid)
            {
                // We can utilise the model
                //Check if email already exist
                var existingUser = await _userManager.FindByEmailAsync(user.Email);
                if(existingUser != null){
                    return BadRequest(new RegistrationResponse(){
                        Errors = new List<string>(){ "Email already in use"},
                        Success = false
                    });
                }

                var newUser = new IdentityUser() { Email = user.Email, UserName = user.Username};
                var isCreated = await _userManager.CreateAsync(newUser, user.Password);
                // check if created went well
                if(isCreated.Succeeded)
                {
                    var jwtToken = GenerateJwtToken(newUser);
                    return Ok(new RegistrationResponse(){
                        Success = true,
                        Token = jwtToken
                    });

                }else {
                     return BadRequest(new RegistrationResponse(){
                        Errors = isCreated.Errors.Select(x => x.Description).ToList(),
                        Success = false
                    });
                }

            }
            return BadRequest( new RegistrationResponse(){
                Errors = new List<string>(){"Invalid payload"},
                Success = false
            });
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest user)
        {
            if(ModelState.IsValid)
            {
                // Check if user exist
                var existingUser = await _userManager.FindByEmailAsync(user.Email);
                if(existingUser == null){
                    return BadRequest(new RegistrationResponse(){
                        Errors = new List<string>(){"Invalid login request"},
                        Success = false
                    });
                }
                // check the password
                var isCorrect = await _userManager.CheckPasswordAsync(existingUser, user.Password);
                if(!isCorrect){
                    return BadRequest(new RegistrationResponse(){
                        Errors = new List<string>(){ "Invalid login request"},
                        Success = false
                    });
                }

                // Generate a token upon login
                var jwtToken = GenerateJwtToken(existingUser);
                return Ok(new RegistrationResponse(){
                    Success = true,
                    Token = jwtToken
                });


            }
            return BadRequest( new RegistrationResponse(){
                Errors = new List<string>(){"Invalid payload"},
                Success = false
            });
        }

        // Token Generator
        private string GenerateJwtToken(IdentityUser user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var Key = Encoding.ASCII.GetBytes(_jwtconfig.Secret);
            // add claim
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new []{
                    new Claim("Id", user.Id),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(6),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token  = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            return jwtToken;
        }
    }
}