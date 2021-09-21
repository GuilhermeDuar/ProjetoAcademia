using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string User_Password { get; set; }
        public Users_Role Role { get; set; }
        public bool Active { get; set; }
        public override string ToString()
        {
            return $"{Role}: {Email}";
        }
    }
}
