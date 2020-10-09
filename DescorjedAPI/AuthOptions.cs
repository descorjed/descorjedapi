using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescorjedAPI
{
    public class AuthOptions
    {
        public const string ISSUER = "DescorjedAuth";
        public const string AUDIENCE = "DescorjedUser";
        private const string KEY = "fhdfjaofhvbaufha"; //Ключ для шифрации, потом поменяю
        public const int LIFETIME = 5; //Время жизни токена в минутах
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
