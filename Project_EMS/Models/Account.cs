using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_EMS.Models
{
    public class Account
    {
        private string acc;
        private string pass;
        private string username;
        private Global.Role role;
        public string Acc { get => acc; set => acc = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Username { get => username; set => username = value; }
        public Global.Role Role { get => role; set => role = value; }
    }
}
