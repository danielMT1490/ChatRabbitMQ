using ChatRabbit.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ChatRabbit.Models
{
    public class DataLayer
    {
            
        public UserModel Login(string email, string password)
        {
            UserModel mindundi = new UserModel
            {
                userid=1,
                email="mindundi@gmail.com",
                mobile="56894875",
                password="mindundi",
                confirmpassword="mindundi",
                dob="14/12/1990"
            };
            UserModel piltrafa = new UserModel
            {
                userid = 1,
                email = "piltrafa@gmail.com",
                mobile = "56894875",
                password = "piltrafa",
                confirmpassword = "mindundi",
                dob = "14/12/1990"
            };
            if (password.Equals(mindundi.password))
            {
                return mindundi;
            }
            else
            {
                return piltrafa;
            }
            
        }

        public List<UserModel> Getusers(int id)
        {
            List<UserModel> userlist = new List<UserModel>
            {
                new UserModel
                {
                 userid=1,
                email="mindundi@gmail.com",
                mobile="56894875",
                password="mindundi",
                confirmpassword="mindundi",
                dob="14/12/1990"
                },
                new UserModel
                {
                 userid=1,
                email="piltrafa@gmail.com",
                mobile="56894875",
                password="piltrafa",
                confirmpassword="piltrafa",
                dob="14/12/1990"
                },
            };
           
            return userlist;
        }
    }
}