using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace TaskManagerPrototype.Models
{
    public class AuthOptions
    {
        public const string ISSUER = "MytaskApp";
        public const string AUDIENCE = "MytaskUser";
        private const string KEY = "rustam";
        public const int LIFETIME = 1;

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}