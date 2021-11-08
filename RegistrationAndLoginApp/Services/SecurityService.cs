using RegistrationAndLoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAndLoginApp.Services
{
    public class SecurityService
    {
        //List<UserModel> knownUsers = new List<UserModel>();
        UsersDAO usersDAO = new UsersDAO();
        public SecurityService()
        {
            //knownUsers.Add(new UserModel { Id = 0, UserName = "KaliBah", Password = "123" });
            //knownUsers.Add(new UserModel { Id = 1, UserName = "BillGates", Password = "bigbucks" });
            //knownUsers.Add(new UserModel { Id = 2, UserName = "AlexanderFleming", Password = "penicillin" });
        }

        public bool IsValid (UserModel user)
        {
            return usersDAO.FindUserByNameAndPassword(user);
            // return true if found in the list 
            //return knownUsers.Any(x => x.UserName == user.UserName && x.Password == user.Password);
        }
    }

}
