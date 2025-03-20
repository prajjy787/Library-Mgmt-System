using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class UserDTO
    {
        private string UserName;
        private string Password;
        private int UserLevel;
        private int UserId;


        public string UserName1 { get => UserName; set => UserName = value; }
        public string Password1 { get => Password; set => Password = value; }
        public int UserLevel1 { get => UserLevel; set => UserLevel = value; }
        public int UserId1 { get => UserId; set => UserId = value; }
    }
}
