using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Controller.ServiceReferenceLibrary;
namespace Controller
{
    public class UserController
    {
        public UserDTO UserLogin(string UserName, string Password)
        {


            /* UserLogic userLogic = new UserLogic();     

             User user = userLogic.UserLogin(UserName, Password);
            */

            // Adding webservice refrence then calling revalent method.

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();

            
         

                Controller.ServiceReferenceLibrary.User user = webServiceLibrarySoapClient.UserLogin(UserName, Password);

                if (user == null) { return null; }


                UserDTO userDTO = new UserDTO();
                userDTO.UserLevel1 = user.UserLevel1;
                userDTO.Password1 = user.Password1;
                userDTO.UserName1 = user.UserName1;
                userDTO.UserId1 = user.UserId1;




                return userDTO;


            }
            
        

            public int UpdatePasswords(string NewPassword, int UID, string Original_Password)
            {

                //  UserLogic userLogic = new UserLogic();

                WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();

                int istatusUP = webServiceLibrarySoapClient.UpdatePasswords(NewPassword, LibraryGlobal.uSER_Id, Original_Password);

                //   int istatusUP = userLogic.UpdatePasswords(NewPassword, LibraryGlobal.uSER_Id, Original_Password);


                return istatusUP;
            }

        public int AddUser(string UserName, string Password, int UserLevel)
        {
            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();


            int istsatuscodeAA = webServiceLibrarySoapClient.AddUser(UserName, Password, UserLevel);


            return istsatuscodeAA;

        }


        public int ModifyUser(string UserName, string Password, int UserLevel, string Original_UserName)
        {
            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();

            int istsatuscodeMU = webServiceLibrarySoapClient.ModifyUser(UserName, Password, UserLevel, Original_UserName);


            return istsatuscodeMU;

        }

        

        public virtual int RemoveUser(string Original_UserName)
        {

            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();

            int istsatuscodeRU = webServiceLibrarySoapClient.RemoveUser(Original_UserName);

            return istsatuscodeRU;


        }


        public List<UserDTO> ShowUser()
        {
            WebServiceLibrarySoapClient webServiceLibrarySoapClient = new WebServiceLibrarySoapClient();
            Controller.ServiceReferenceLibrary.User[] users = webServiceLibrarySoapClient.ShowUser();

            List<UserDTO> userDTOs = new List<UserDTO>();

            foreach (Controller.ServiceReferenceLibrary.User user in users)
            {
                UserDTO userDTO = new UserDTO();
                userDTO.UserName1 = user.UserName1;
                userDTO.Password1 = user.Password1;
                userDTO.UserLevel1 = user.UserLevel1;
                userDTO.UserId1 = user.UserId1;







                userDTOs.Add(userDTO);
            }






            return userDTOs;

        }


    }
    } 
