using Module.UserDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    public class UserLogic
    {
        public User UserLogin(string UserName, string Password)
        {
            UserDAO userDAO = new UserDAO();
            User user = userDAO.UserLogin(UserName, Password);
            return user;
        }

        public int UpdatePasswords(string NewPassword, int UID, string Original_Password)
        {

            UserDAO userDAO = new UserDAO();

            int istatusUP = userDAO.UpdatePasswords(NewPassword, UID, Original_Password);


            return istatusUP;
        }


    }
}

