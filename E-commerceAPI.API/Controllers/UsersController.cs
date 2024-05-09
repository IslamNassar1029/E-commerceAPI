using E_commerceAPI.API.DTOs.User;
using E_commerceAPI.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace E_commerceAPI.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        private readonly UserManager<User> _userManager;

        public UsersController(IConfiguration configuration, UserManager<User> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }
        
        [HttpPost]
        [Route("register")]
        public async Task<ActionResult> Register(RegisterDTO registerDTO)
        {
            var user = new User
            {
                UserName = registerDTO.UserName,
                Email = registerDTO.Email,
            };
            var result = await _userManager.CreateAsync(user, registerDTO.Password);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            var claims = new List<Claim>
            {
                new (ClaimTypes.NameIdentifier,user.Id.ToString()),
                new (ClaimTypes.Name, user.UserName),
                new (ClaimTypes.Email, user.Email),
                new (ClaimTypes.Role, "User"),
            };
            await _userManager.AddClaimsAsync(user, claims);

            return Ok("succeed");
        }


        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<TokenDTO>> Login(LoginDTO Credentials)
        {
            var user = await _userManager.FindByNameAsync(Credentials.UserName);
            if (user == null)
            {
                return Unauthorized("wrong Credentials");
            }
            if (await _userManager.IsLockedOutAsync(user))
            {
                return BadRequest("try again after 2 minute");
            }
            bool isAuthenticated = await _userManager.CheckPasswordAsync(user, Credentials.Password);

            if (!isAuthenticated)
            {
                await _userManager.AccessFailedAsync(user);
                return Unauthorized("wrong Credentials");
            }

            var userClaims = await _userManager.GetClaimsAsync(user);
            return GenerateToken(userClaims);
        }
        //remove  for trying only
        [Authorize]
        [HttpGet]
        [Route("UseAuthentication")]
        public ActionResult<string> Authentica(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            return userId;
        }
        [Authorize(Policy = "AdminOnly")]
        [HttpGet]
        [Route("UseAuthorization")]
        public ActionResult<int> authorize(int id)
        {
            return 900000;
        }

        private ActionResult<TokenDTO> GenerateToken(IEnumerable<Claim> UserClaims)
        {
            var secretKey = _configuration.GetValue<string>("SecretKey")!;
            var keyInBytes = Encoding.ASCII.GetBytes(secretKey);
            var key = new SymmetricSecurityKey(keyInBytes);
            var signingCredentails = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var expiryDateTime = DateTime.Now.AddDays(30);

            var jwt = new JwtSecurityToken(
                claims: UserClaims,
                expires: expiryDateTime,
                signingCredentials: signingCredentails
                );

            var tokenHandler = new JwtSecurityTokenHandler();

            string tokenString = tokenHandler.WriteToken(jwt);


            return new TokenDTO(tokenString, expiryDateTime);
        }
    }


   
}
