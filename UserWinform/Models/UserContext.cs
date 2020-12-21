using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserWinform.Models
{
    class UserContext:DbContext
    {
        static UserContext()
        {
            Database.SetInitializer<UserContext>(null);
            //Database.SetInitializer(new CreateDatabaseIfNotExists<PortalContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<PortalContext>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PortalContext>());
        }
        public UserContext():base("name=UserContext")
            {
            
            }
        public DbSet<User> Users { get; set; }
        public DbSet<Province> Provinces { get; set; }
    }
}
