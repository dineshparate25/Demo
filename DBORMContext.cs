using MySql.Data.EntityFramework;
using SecureWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SecureWebApp.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DBORMContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<RoleMaster> Roles { get; set; }
        public DbSet<RoleMapping> UserRoleMappings { get; set; }
        public DBORMContext() : base("WebAppCon")
        {
        }
    }
}