using OnlineShopping.DataAccess.DataContext;
using OnlineShopping.DataAccess.Entity;
using OnlineShopping.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.DataAccess.Functions
{
    public class UserFunctions:IUser
    {
        //add a new user
        public async Task<User> AddUser(string email, string fName, string lName, string address, string password)
        {
            User newUser = new User
            {
                Email = email,
                FName=fName,
                LName=lName,
                Address=address,
                Password=password

            };
            using(var context=new DatabaseContext(DatabaseContext.ops.dbOptions))
            {
                await context.User.AddAsync(newUser);
                await context.SaveChangesAsync();
            }
            return newUser;
                
        
        }
    }
}
