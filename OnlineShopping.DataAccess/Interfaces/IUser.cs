using OnlineShopping.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.DataAccess.Interfaces
{
    public interface IUser
    {
        Task<User> AddUser(string email, string fName, string lName, string address, string password);
    }
}
