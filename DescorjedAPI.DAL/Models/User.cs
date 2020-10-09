using System;
using System.Collections.Generic;
using System.Text;

namespace DescorjedAPI.DAL.Models
{
    public class User : Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        
    }
}
