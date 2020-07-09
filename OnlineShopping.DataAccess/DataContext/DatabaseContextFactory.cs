using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace OnlineShopping.DataAccess.DataContext
{
    public class DatabaseContextFactory:IDesignTimeDbContextFactory<DatabaseContext>
    {
        DatabaseContext IDesignTimeDbContextFactory<DatabaseContext>.CreateDbContext(string[] args)
        {
            AppConfiguration appConfig = new AppConfiguration();
            var opsBuillder = new DbContextOptionsBuilder<DatabaseContext>();
            opsBuillder.UseSqlServer(appConfig.sqlConnectionString);//grab connection string
            return new DatabaseContext(opsBuillder.Options);
        }
    }
}
