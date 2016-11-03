using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XData
{
    public class XContext : DbContext
    {
        public XContext()
            : base("Name=DefaultConnection")
        {
            //Database.SetInitializer<XContext>(new FTFContextInitializer());
        }

        //public DbSet<User> Users { get; set; }
        //public DbSet<Profile> Profiles { get; set; }
    }
}

