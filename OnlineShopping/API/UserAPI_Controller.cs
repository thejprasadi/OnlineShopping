using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Business.UserLogic;

namespace OnlineShopping.WebAPI.API
{
    [Route("api/user/")]
    [ApiController]
    public class UserAPI_Controller : ControllerBase
    {
        private UserLogic userLogic = new UserLogic();

        //add user
        [Route("add")]
        [HttpGet]

        public async Task<Boolean> AddUser(string email, string fName, string lName, string address, string password)
        {
            bool result=await userLogic.CreateNewUser(email, fName, lName, address, password);
            return result;
        }
    }
}
