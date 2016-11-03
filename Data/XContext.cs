using Bida.Data.Configurations;
using Bida.Data.CustomConventions;
using Bida.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class XContext : DbContext
    {
        public XContext()
            : base("Name=DefaultConnection")
        {
            //Database.SetInitializer<XContext>(new FTFContextInitializer());
        }

        //public DbSet<User> Clients { get; set; }
        //public DbSet<Profile> Commandes { get; set; }
    }
}
