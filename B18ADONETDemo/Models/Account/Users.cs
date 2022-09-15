using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Account
{
    public class Users
    {

        public int UsersId { get; set; }
        public Guid UserGuid { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public bool IsEmailConfirmed { get; set; }
        public DateTime RegisteredDate { get; set; }
    }
}
