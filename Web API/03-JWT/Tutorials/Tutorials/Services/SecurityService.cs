using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Tutorials.Constants;
using Tutorials.Helpers;
using Tutorials.Models;

namespace Tutorials.Services
{
    public class SecurityService : ISecurityService
    {
        public JwtResponse IssueJwtToken(User user)
        {
            var now = DateTime.Now;
            var claims = new List<Claim>()
            { 
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, user.UserName == "Saba" ? "Admin" : "User")
            };

            var Jwt = new JwtSecurityToken(
                issuer: AuthOptions.Issuer,
                audience: AuthOptions.Audience,
                claims: claims,
                notBefore: now,
                expires: now.AddMinutes(AuthOptions.TokenLifeTime),
                signingCredentials: new SigningCredentials(AuthOptions.GetKey, SecurityAlgorithms.HmacSha256)
                );

            var token = new JwtSecurityTokenHandler().WriteToken(Jwt);

            return new JwtResponse { Token = token, UserName = user.UserName };
        }

        public bool VerifyUserPassword(User user, string Password)
        {
            return user.HashedPassword == Password.Hash();
        }
    }
}
