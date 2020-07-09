using OnlineShopping.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Business.UserLogic
{
   public class UserLogic
    {
        private IUser user = new DataAccess.Functions.UserFunctions();//interface intantiation

        //add new user
        public async Task<Boolean> CreateNewUser(string email, string fName, string lName, string address, string password)
        {
            try
            {
                var result = await user.AddUser(email, fName, lName, address, password);
                if (result.Id > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception eror)
            {
                return false;
            }
        }


    }
}
