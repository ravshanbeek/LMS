using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LMS.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private IConfiguration _configuration;

        public AuthenticationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async ValueTask<string> TokenGenerateAsync(IEnumerable<Claim> claims)
        {
            var issuer = _configuration["JWT:Issuer"];
            var audience = _configuration["JWT:Audience"];
            var key = _configuration["JWT:Key"];

            var securityToken = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: new SigningCredentials(
                    key: new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
                    algorithm: SecurityAlgorithms.HmacSha256)
            );
            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }

        public async ValueTask<string> TokenGenerateAsync()//qaysidur userDto jo'natamiz
        {
            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Role,"Admin")
            };

            return await TokenGenerateAsync(claims);
        }
    }
}
