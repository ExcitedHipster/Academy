using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.Constants
{
    public class AuthOptions
    {
        public const string Issuer = "JwtTutorialsIssuer";
        public const string Audience = "JwtTutorialClient";
        const string Key = "WherySecretString";
        public const int TokenLifeTime = 5;
        public static SymmetricSecurityKey GetKey =>
            new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Key));
    }
}
